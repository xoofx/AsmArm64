// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using Spectre.Console;

namespace AsmArm64.CodeGen;

class InstructionTrieNode
{
    public InstructionTrieNode()
    {
        MaskToSubDecoder = new();
        InstructionIndices = new();
        BitMask = uint.MaxValue;
    }

    public uint Key;

    public uint BitMask;

    public uint RightShift;

    public readonly Dictionary<uint, InstructionTrieNode> MaskToSubDecoder;

    public InstructionTrieNode? ElseBranch;

    public readonly List<int> InstructionIndices;

    public bool IsElseBranch;

    public TrieTableKind TableKind;

    public uint DecoderArrayLength;

    public ulong HashMultiplier;

    public InstructionTrieNode? Parent;

    public bool IsTerminal => MaskToSubDecoder.Count == 0;

    public void RecursiveBuild(ProgressContext ctx, ProgressTask task, List<Instruction> instructions, List<InstructionTrieNode> allDecoders, int level = 0)
    {
        if (InstructionIndices.Count == 0) return;
        
        if (InstructionIndices.Count == 1)
        {
            Console.WriteLine($"{new string(' ', level * 2)}0x{Key:X8} -> {instructions[InstructionIndices[0]]}");

            task.Increment(1);
            TableKind = TrieTableKind.Terminal;
            return;
        }

        var parentBitMask = BitMask;
        uint sharedBitMask = parentBitMask;

        foreach (var instructionIndex in InstructionIndices)
        {
            var instruction = instructions[instructionIndex];
            sharedBitMask &= instruction.BitfieldMask;
        }

        BitMask = sharedBitMask;

        bool isSupersetMask = false;

        var set = new HashSet<uint>();
        foreach (var instructionIndex in InstructionIndices)
        {
            var instruction = instructions[instructionIndex];
            var localSubIndex = (uint)instruction.BitfieldValue & sharedBitMask;
            set.Add(localSubIndex);
        }

        // If all keys are folding to the same value, we need to find a better mask
        if (set.Count == 1)
        {
            set.Clear();
            foreach (var instructionIndex in InstructionIndices)
            {
                var instruction = instructions[instructionIndex];
                var mask = (uint)instruction.BitfieldMask & parentBitMask;
                set.Add(mask);
            }

            // Search for a mask that is a superset of other masks in the same set
            var isSuperset = true;
            uint superSetMask = 0;
            foreach (var mask in set)
            {
                isSuperset = true;
                foreach (var otherMask in set)
                {
                    if (mask == otherMask) continue;
                    if ((mask & otherMask) != otherMask)
                    {
                        isSuperset = false;
                        break;
                    }
                }

                if (isSuperset)
                {
                    superSetMask = mask;
                    break;
                }
            }

            if (isSuperset)
            {
                sharedBitMask = superSetMask;
                BitMask = sharedBitMask;
                isSupersetMask = true;
            }
            else
            {
                // select the mask with the most bits set
                var maxBitCount = 0;
                foreach (var mask in set)
                {
                    var bitCount = BitOperations.PopCount(mask);
                    if (bitCount > maxBitCount)
                    {
                        maxBitCount = bitCount;
                        sharedBitMask = mask;
                        BitMask = sharedBitMask;
                        isSupersetMask = true;
                    }
                }
            }
        }

        RightShift = (uint)BitOperations.TrailingZeroCount(BitMask);

        //Console.WriteLine($"{new string(' ', level * 2)} Decoder Shift = {LeftShift}, BitMaskCount = {BitMaskCount}");
        //Console.WriteLine($"{new string(' ', level * 2)} Decoder Shift = {Shift}, DecoderMask = {buildMask}");

        Debug.Assert(level < 20);
        
        //for (var i = 0; i < 32; i++)
        //{
        //    var hashSet = instCountPerFront1[i];
        //    if (hashSet.CountPerMask is not null && hashSet.Count > 0)
        //    {
        //        Console.WriteLine($"{new string(' ', level * 2)} [{i}] CountPerMask = {hashSet.CountPerMask.Count}, Total = {hashSet.Count}");
        //    }
        //}

        foreach (var instructionIndex in InstructionIndices)
        {
            var instruction = instructions[instructionIndex];
            var localSubIndex = (uint)instruction.BitfieldValue & sharedBitMask;

            if (isSupersetMask && (instruction.BitfieldMask & parentBitMask) != sharedBitMask)
            {
                ElseBranch ??= new InstructionTrieNode()
                {
                    IsElseBranch = true,
                    Parent = this,
                    BitMask = parentBitMask
                };

                if (!ElseBranch.InstructionIndices.Contains(instructionIndex))
                {
                    ElseBranch.InstructionIndices.Add(instructionIndex);
                }
            }
            else
            {
                if (!MaskToSubDecoder.TryGetValue(localSubIndex, out var subDecoder))
                {
                    subDecoder = new InstructionTrieNode()
                    {
                        Key = localSubIndex,
                        Parent = this,
                        BitMask = ~sharedBitMask
                    };
                    allDecoders.Add(subDecoder);
                    MaskToSubDecoder.Add(localSubIndex, subDecoder);
                }

                if (!subDecoder.InstructionIndices.Contains(instructionIndex))
                {
                    subDecoder.InstructionIndices.Add(instructionIndex);
                }
            }
        }

        if (MaskToSubDecoder.Count == 1 && ElseBranch is null)
        {
            Console.WriteLine($"{new string(' ', level * 2)}[{level}] Decoder Key = 0x{Key:X8}, BitMask = 0x{BitMask:X8}, Shift = {RightShift} {(IsElseBranch ? " - Else":"")} - INVALID");
            foreach(var instructionIndex in InstructionIndices)
            {
                Console.WriteLine($"{new string(' ', level * 2)}  Instr: {instructions[instructionIndex]}");
            }
        }
        else
        {
            Console.WriteLine($"{new string(' ', level * 2)}[{level}] Decoder Key = 0x{Key:X8}, BitMask = 0x{BitMask:X8}, Shift = {RightShift} {(IsElseBranch ? " - Else":"")}");
            foreach (var subDecoder in MaskToSubDecoder.Values)
            {
                subDecoder.RecursiveBuild(ctx, task, instructions, allDecoders, level + 1);
            }

            if (ElseBranch is not null)
            {
                ElseBranch.RecursiveBuild(ctx, task, instructions, allDecoders, level + 1);
            }
        }
    }

    public void PrepareForHash(ProgressContext ctx, ProgressTask progressTask)
    {
        return;

        if (IsTerminal)
        {
            progressTask.Increment(1.0);

            if (InstructionIndices.Count != 1)
            {
                Console.WriteLine($"Error with decoder. Invalid number of final instructions expecting only 1: {this}");
            }

            TableKind = TrieTableKind.Terminal;
            return;
        }

        var maximumNumberOfElements = 1 << 1000;

        var ratio = MaskToSubDecoder.Keys.Count / (double)maximumNumberOfElements;

        if (ratio > 0.5) // For direct access, we require 50% of the elements
        {
            progressTask.Increment(1.0);
            // Direct array
            TableKind = TrieTableKind.ArrayDirectIndex;
            DecoderArrayLength = (uint)maximumNumberOfElements;
            //Console.WriteLine($"Direct Array: {ratio}, {MaskToSubDecoder.Keys.Count}/{maximumNumberOfElements}"); 
        }
        else
        {
            if (MaskToSubDecoder.Keys.Count <= 10)
            {
                DecoderArrayLength = (uint)MaskToSubDecoder.Keys.Count;
                progressTask.Increment(1.0);
                TableKind = TrieTableKind.SmallArray;
            }
            else
            {
                TableKind = TrieTableKind.Hash;

                var keyArray = MaskToSubDecoder.Keys.ToArray();

                // Calculate the best multiplier and hash table size to have 0 collisions
                // The following code is brute force and quite sensitive to changes
                // In case of a change, verify the new size vs old before committing
                Task[] tasks = new Task[128]; // 128
                for (int j = 0; j < tasks.Length; j++)
                {
                    int localJ = j;

                    tasks[j] = Task.Run<(uint Length, ulong Modifier)>(() =>
                        {
                            var idealLength = keyArray.Length;
                            var length = idealLength;

                            var hashSet = new HashSet<uint>();
                            Random rng = new Random((int)((localJ + 1) * 307));
                            while (true)
                            {
                                bool hasCollision = false;

                                ulong modifier = (ulong)GetNext(rng);
                                for (int tryCount = 0; tryCount < 200_000; tryCount++)
                                {
                                    hashSet.Clear();
                                    hasCollision = false;
                                    foreach (var key in keyArray)
                                    {
                                        var hash = (uint)(((uint)key * modifier) % (uint)length);

                                        if (!hashSet.Add(hash))
                                        {
                                            hasCollision = true;
                                            break;
                                        }
                                    }

                                    if (!hasCollision)
                                    {
                                        break;
                                    }

                                    modifier = GetNext(rng);
                                }

                                if (!hasCollision)
                                {
                                    progressTask.Increment(1.0 / 128.0);
                                    //ctx.Refresh();
                                    return ((uint)length, modifier);
                                }

                                // Go to the next prime number for the hash table
                                var newLength = HashHelpers.GetPrime(length);
                                // We were already on a prime?
                                if (newLength == length)
                                {
                                    // go to the next prime
                                    newLength = HashHelpers.GetPrime(length + 1);
                                }

                                length = newLength;
                            }

                            return (0, 0);
                        }
                    );
                }

                while (!Task.WaitAll(tasks, 10))
                {
                    ctx.Refresh();
                }

                int bestLength = int.MaxValue;
                ulong bestModifier = 0;
                foreach (var task in tasks)
                {
                    var (length, modifier) = ((Task<(uint, ulong)>)task).Result;
                    if (length < bestLength)
                    {
                        bestLength = (int)length;
                        bestModifier = modifier;
                    }
                }

                DecoderArrayLength = (uint)bestLength;
                HashMultiplier = bestModifier;

                //Console.WriteLine($"Hash - Modifier 0x{bestModifier:X16}, New Length: {bestLength}, Old Length: {keyArray.Length}");
            }
        }
    }

    private static uint Hasher(uint key, uint length, ulong modifier)
    {
        return (uint)(((ulong)key * modifier) % length);
    }

    private ulong GetNext(Random rng) => (ulong)rng.NextInt64();

    private ulong GetNext(RandomNumberGenerator rng)
    {
        Span<byte> buffer = stackalloc byte[8];
        rng.GetBytes(buffer);
        return BitConverter.ToUInt64(buffer);
    }

    public void Print(TextWriter writer, List<Instruction> instructions, int level = 0)
    {
        var builder = new StringBuilder();
        builder.Append($"{new string(' ', level * 2)}[{level}] BitMask: 0x{BitMask:X8}, Instructions: {InstructionIndices.Count}");

        if (MaskToSubDecoder.Count > 0)
        {
            builder.Append($", Sub-Key Count: {MaskToSubDecoder.Count}");
        }

        //if (Key.HasValue)
        //{
        //    builder.Append($", Key: {Key.Value}");
        //}

        if (IsElseBranch)
        {
            builder.Append($", ElseBranch: true");
        }

        if (MaskToSubDecoder.Count == 0)
        {
            if (InstructionIndices.Count > 1)
            {
                builder.AppendLine($", Invalid-Multi: true");
            }
            else
            {
                builder.AppendLine();

            }

            foreach (var instructionIndex in InstructionIndices)
            {
                builder.AppendLine($"{new string(' ', level * 2)}  Instr: {instructions[instructionIndex]}");
            }
        }
        else
        {
            builder.AppendLine();
        }

        writer.Write(builder.ToString());

        var values = MaskToSubDecoder.Values.ToHashSet().ToList();
        values.Sort((a, b) => a.Key.CompareTo(b.Key));

        foreach (var decoder in values)
        {
            decoder.Print(writer, instructions, level + 1);
        }

        if (ElseBranch is not null)
        {
            ElseBranch.Print(writer, instructions, level);
        }

    }
}