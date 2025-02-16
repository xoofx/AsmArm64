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
public class Arm64InstructionFactoryTests_PACNBIBSPPC_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACNBIBSPPC"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACNBIBSPPC_64lr_dp_1src_0()
    {
        TestInst(PACNBIBSPPC(), Arm64InstructionId.PACNBIBSPPC_64lr_dp_1src, Arm64Mnemonic.PACNBIBSPPC, "PACNBIBSPPC");
    }
}
