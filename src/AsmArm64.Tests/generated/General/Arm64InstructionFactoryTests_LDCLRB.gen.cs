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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_LDCLRB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDCLRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDCLRB_32_memop_0()
    {
        TestInst(LDCLRB(W0, W1, _[X3]), Arm64InstructionId.LDCLRB_32_memop, Arm64Mnemonic.LDCLRB, "LDCLRB W0, W1, [X3]");
        TestInst(LDCLRB(W15, W1, _[X3]), Arm64InstructionId.LDCLRB_32_memop, Arm64Mnemonic.LDCLRB, "LDCLRB W15, W1, [X3]");
        TestInst(LDCLRB(WZR, W1, _[X3]), Arm64InstructionId.LDCLRB_32_memop, Arm64Mnemonic.LDCLRB, "LDCLRB WZR, W1, [X3]");
        TestInst(LDCLRB(W0, W16, _[X3]), Arm64InstructionId.LDCLRB_32_memop, Arm64Mnemonic.LDCLRB, "LDCLRB W0, W16, [X3]");
        TestInst(LDCLRB(W15, W16, _[X3]), Arm64InstructionId.LDCLRB_32_memop, Arm64Mnemonic.LDCLRB, "LDCLRB W15, W16, [X3]");
        TestInst(LDCLRB(WZR, W16, _[X3]), Arm64InstructionId.LDCLRB_32_memop, Arm64Mnemonic.LDCLRB, "LDCLRB WZR, W16, [X3]");
        TestInst(LDCLRB(W0, WZR, _[X3]), Arm64InstructionId.STCLRB_ldclrb_32_memop, Arm64Mnemonic.STCLRB, "STCLRB W0, [X3]");
        TestInst(LDCLRB(W15, WZR, _[X3]), Arm64InstructionId.STCLRB_ldclrb_32_memop, Arm64Mnemonic.STCLRB, "STCLRB W15, [X3]");
        TestInst(LDCLRB(WZR, WZR, _[X3]), Arm64InstructionId.STCLRB_ldclrb_32_memop, Arm64Mnemonic.STCLRB, "STCLRB WZR, [X3]");
    }
}
