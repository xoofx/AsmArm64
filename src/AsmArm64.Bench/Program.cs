using System.Diagnostics;

namespace AsmArm64.Bench;

internal class Program
{
    // 10 -> 440
    // 5 -> 372.523


    static void Main(string[] args)
    {
        int validInstructions = 0;
        var clock = Stopwatch.StartNew();
        for (ulong instruction = 0; instruction <= uint.MaxValue; instruction++)
        {
            //Console.WriteLine($"Processing instruction {instruction}");
            //Console.Out.Flush();
            var test = Arm64Instruction.DecodeId((uint)instruction);
            if (test != Arm64InstructionId.Invalid)
            {
                validInstructions++;
            }

            if (instruction % (16 * 1024 * 1024) == 0)
            {
                var p = (double)instruction / uint.MaxValue;
                Console.Write($"Progress: {p:P} {clock.Elapsed.TotalSeconds:0.000}s\r");
            }
            //    Console.WriteLine($"Count: {instruction}");
            //    if (instruction > 10_000_000)
            //    {
            //        break;
            //    }
            //}
        }
        Console.WriteLine();
        clock.Stop();

        Console.WriteLine($"Valid instructions: {validInstructions} in {clock.Elapsed.TotalSeconds:0.000}s");
    }
}