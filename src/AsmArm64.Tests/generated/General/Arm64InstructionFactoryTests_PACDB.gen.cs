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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_PACDB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACDB"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACDB_64p_dp_1src_0()
    {
        TestInst(PACDB(X0, X2), asm => asm.PACDB(X0, X2), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB X0, X2");
        TestInst(PACDB(X15, X2), asm => asm.PACDB(X15, X2), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB X15, X2");
        TestInst(PACDB(XZR, X2), asm => asm.PACDB(XZR, X2), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB XZR, X2");
        TestInst(PACDB(X0, X18), asm => asm.PACDB(X0, X18), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB X0, X18");
        TestInst(PACDB(X15, X18), asm => asm.PACDB(X15, X18), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB X15, X18");
        TestInst(PACDB(XZR, X18), asm => asm.PACDB(XZR, X18), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB XZR, X18");
        TestInst(PACDB(X0, SP), asm => asm.PACDB(X0, SP), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB X0, SP");
        TestInst(PACDB(X15, SP), asm => asm.PACDB(X15, SP), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB X15, SP");
        TestInst(PACDB(XZR, SP), asm => asm.PACDB(XZR, SP), Arm64InstructionId.PACDB_64p_dp_1src, Arm64Mnemonic.PACDB, "PACDB XZR, SP");
    }
}
