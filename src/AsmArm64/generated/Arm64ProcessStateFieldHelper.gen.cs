// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
// ------------------------------------------------------------------------------
// This code was generated by AsmArm64.CodeGen.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// ------------------------------------------------------------------------------
// ReSharper disable All
// ------------------------------------------------------------------------------
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Decode ProcessStateField class.
/// </summary>
static class Arm64ProcessStateFieldHelper
{
    public static bool TryDecode(Arm64RawInstruction rawValue, byte mapIndex, out Arm64ProcessStateField processStateField)
    {
        switch (mapIndex)
        {
            // MSR_si_pstate                 : MSR         pstatefield, #imm <- Operand: pstatefield
            case 1:
            {
                var bitValue = ((rawValue >> 5) & 0x7) | ((rawValue >> 13) & 0x38) | ((rawValue >> 2) & 0x3C0);
                var bitsToTest = (bitValue & 0x3FF);
                if ((bitsToTest & 0x3bf) == 8)
                {
                    processStateField = Arm64ProcessStateField.ALLINT;
                    return true;
                }
                if ((bitsToTest & 0x3bf) == 136)
                {
                    processStateField = Arm64ProcessStateField.PM;
                    return true;
                }
                if ((bitsToTest & 0x3bf) == 155)
                {
                    processStateField = Arm64ProcessStateField.SVCRSM;
                    return true;
                }
                if ((bitsToTest & 0x3bf) == 283)
                {
                    processStateField = Arm64ProcessStateField.SVCRZA;
                    return true;
                }
                if ((bitsToTest & 0x3bf) == 411)
                {
                    processStateField = Arm64ProcessStateField.SVCRSMZA;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 3)
                {
                    processStateField = Arm64ProcessStateField.UAO;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 4)
                {
                    processStateField = Arm64ProcessStateField.PAN;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 5)
                {
                    processStateField = Arm64ProcessStateField.SPSel;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 25)
                {
                    processStateField = Arm64ProcessStateField.SSBS;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 26)
                {
                    processStateField = Arm64ProcessStateField.DIT;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 28)
                {
                    processStateField = Arm64ProcessStateField.TCO;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 30)
                {
                    processStateField = Arm64ProcessStateField.DAIFSet;
                    return true;
                }
                if ((bitsToTest & 0x3f) == 31)
                {
                    processStateField = Arm64ProcessStateField.DAIFClr;
                    return true;
                }
                break;
            }
        }
        
        processStateField = default;
        return false;
    }
}
