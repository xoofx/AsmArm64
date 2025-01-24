// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

[TestClass]
public class TestSystemRegisters
{
    [TestMethod]
    public void TestToString()
    {
        {
            Arm64SystemRegister register = Arm64SystemRegisterKnownId.ACCDATA_EL1;
            Assert.AreEqual("ACCDATA_EL1", register.ToString());
            Assert.AreEqual("S3_0_C13_C0_5", register.ToString("G"));
            Assert.AreEqual(Arm64SystemRegisterKind.MRS | Arm64SystemRegisterKind.MSR, register.Kind);
            Assert.AreEqual(Arm64SystemRegisterKnownId.ACCDATA_EL1, register.Id);
            Assert.AreEqual(50_821, register.Value);
        }

        {
            Arm64SystemRegister register = Arm64SystemRegisterKnownId.ZVA;
            Assert.AreEqual("ZVA", register.ToString());
            Assert.AreEqual("S1_3_C7_C4_1", register.ToString("G"));
            Assert.AreEqual(Arm64SystemRegisterKind.DC, register.Kind);
            Assert.AreEqual(Arm64SystemRegisterKnownId.ZVA, register.Id);
            Assert.AreEqual(23457, register.Value);
        }
    }
}