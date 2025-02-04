// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

/// <summary>
/// Tests for all structs inheriting from <see cref="IArm64MemoryAccessor"/>.
/// </summary>
[TestClass]
public class TestMemoryAccessor
{
    [TestMethod]
    public void TestEmpty()
    {
        var memoryAccessor = new Arm64MemoryAccessorAny();
        Assert.AreEqual(Arm64MemoryBaseRegisterKind.None, memoryAccessor.BaseRegisterKind);
        Assert.AreEqual(default, memoryAccessor.BaseRegister);
        Assert.AreEqual(default, memoryAccessor.IndexRegister);
        Assert.IsFalse(memoryAccessor.HasExtend);
        Assert.AreEqual(default, memoryAccessor.Extend);
        Assert.IsFalse(memoryAccessor.HasIndexRegister);
        Assert.AreEqual(default, memoryAccessor.IndexRegister);
        Assert.IsFalse(memoryAccessor.HasImmediate);
        Assert.AreEqual(0, memoryAccessor.Immediate);
        Assert.IsFalse(memoryAccessor.IsPreIncrement);
        Assert.IsFalse(memoryAccessor.HasOptionalOffset);
        Assert.AreEqual("[??]", memoryAccessor.ToString());
    }

    [TestMethod]
    public void TestBaseRegisterXOrSP()
    {
        {
            var memoryAccessor = new Arm64BaseMemoryAccessor(Arm64RegisterX.X2);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X2, memoryAccessor.BaseRegister);
            Assert.IsFalse(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsFalse(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(default, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x2]", memoryAccessor.ToString());
        }
        {
            var memoryAccessor = new Arm64BaseMemoryAccessor(Arm64RegisterSP.SP);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterSP.SP, memoryAccessor.BaseRegister);
            Assert.IsFalse(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsFalse(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(default, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[sp]", memoryAccessor.ToString());
        }
    }

    [TestMethod]
    public void TestBaseRegisterX()
    {
        {
            var memoryAccessor = new Arm64BaseXMemoryAccessor(Arm64RegisterX.X30);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterX, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X30, memoryAccessor.BaseRegister);
            Assert.IsFalse(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsFalse(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(default, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x30]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterX, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X30, pre.BaseRegister);
            Assert.IsFalse(pre.HasExtend);
            Assert.AreEqual(default, pre.Extend);
            Assert.IsFalse(pre.HasIndexRegister);
            Assert.AreEqual(default, pre.IndexRegister);
            Assert.IsFalse(pre.HasImmediate);
            Assert.AreEqual(0, pre.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[x30]!", pre.ToString());
        }
        {
            var memoryAccessor = new Arm64BaseXMemoryAccessor(Arm64RegisterX.XZR);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterX, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.XZR, memoryAccessor.BaseRegister);
            Assert.IsFalse(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsFalse(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(default, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[xzr]", memoryAccessor.ToString());
            
            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterX, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.XZR, pre.BaseRegister);
            Assert.IsFalse(pre.HasExtend);
            Assert.AreEqual(default, pre.Extend);
            Assert.IsFalse(pre.HasIndexRegister);
            Assert.AreEqual(default, pre.IndexRegister);
            Assert.IsFalse(pre.HasImmediate);
            Assert.AreEqual(0, pre.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[xzr]!", pre.ToString());
        }
    }

    [TestMethod]
    public void TestImmediate()
    {
        {
            var memoryAccessor = new Arm64ImmediateMemoryAccessor(Arm64RegisterX.X3, 125);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, memoryAccessor.BaseRegister);
            Assert.IsFalse(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsFalse(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(default, memoryAccessor.IndexRegister);
            Assert.IsTrue(memoryAccessor.HasImmediate);
            Assert.AreEqual(125, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x3, #125]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, pre.BaseRegister);
            Assert.IsFalse(pre.HasExtend);
            Assert.AreEqual(default, pre.Extend);
            Assert.IsFalse(pre.HasIndexRegister);
            Assert.AreEqual(default, pre.IndexRegister);
            Assert.IsTrue(pre.HasImmediate);
            Assert.AreEqual(125, memoryAccessor.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[x3, #125]!", pre.ToString());
        }
        {
            var memoryAccessor = new Arm64ImmediateMemoryAccessor(Arm64RegisterSP.SP, -65535);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterSP.SP, memoryAccessor.BaseRegister);
            Assert.IsFalse(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsFalse(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(default, memoryAccessor.IndexRegister);
            Assert.IsTrue(memoryAccessor.HasImmediate);
            Assert.AreEqual(-65535, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[sp, #-65535]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterSP.SP, pre.BaseRegister);
            Assert.IsFalse(pre.HasExtend);
            Assert.AreEqual(default, pre.Extend);
            Assert.IsFalse(pre.HasIndexRegister);
            Assert.AreEqual(default, pre.IndexRegister);
            Assert.IsTrue(pre.HasImmediate);
            Assert.AreEqual(-65535, memoryAccessor.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[sp, #-65535]!", pre.ToString());
        }
    }

    [TestMethod]
    public void TestIndexRegisterX()
    {
        {
            var memoryAccessor = new Arm64RegisterXExtendMemoryAccessor(Arm64RegisterX.X3, Arm64RegisterX.X1,  default);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, memoryAccessor.BaseRegister);
            Assert.IsTrue(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsTrue(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterX.X1, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x3, x1]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, pre.BaseRegister);
            Assert.IsTrue(pre.HasExtend);
            Assert.AreEqual(default, pre.Extend);
            Assert.IsTrue(pre.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterX.X1, pre.IndexRegister);
            Assert.IsFalse(pre.HasImmediate);
            Assert.AreEqual(0, pre.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[x3, x1]!", pre.ToString());
        }

        {
            var memoryAccessor = new Arm64RegisterXExtendMemoryAccessor(Arm64RegisterX.X3, Arm64RegisterX.X1, new(new IArm64ExtendKind.LSL(), 4));
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, memoryAccessor.BaseRegister);
            Assert.IsTrue(memoryAccessor.HasExtend);
            Assert.AreEqual(new(new IArm64ExtendKind.LSL(), 4), memoryAccessor.Extend);
            Assert.IsTrue(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterX.X1, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x3, x1, lsl #4]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, pre.BaseRegister);
            Assert.IsTrue(pre.HasExtend);
            Assert.AreEqual(new(new IArm64ExtendKind.LSL(), 4), pre.Extend);
            Assert.IsTrue(pre.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterX.X1, pre.IndexRegister);
            Assert.IsFalse(pre.HasImmediate);
            Assert.AreEqual(0, pre.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[x3, x1, lsl #4]!", pre.ToString());
        }
    }

    [TestMethod]
    public void TestIndexRegisterW()
    {
        {
            var memoryAccessor = new Arm64RegisterWExtendMemoryAccessor(Arm64RegisterX.X3, Arm64RegisterW.W1, default);
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, memoryAccessor.BaseRegister);
            Assert.IsTrue(memoryAccessor.HasExtend);
            Assert.AreEqual(default, memoryAccessor.Extend);
            Assert.IsTrue(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterW.W1, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x3, w1]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, pre.BaseRegister);
            Assert.IsTrue(pre.HasExtend);
            Assert.AreEqual(default, pre.Extend);
            Assert.IsTrue(pre.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterW.W1, pre.IndexRegister);
            Assert.IsFalse(pre.HasImmediate);
            Assert.AreEqual(0, pre.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[x3, w1]!", pre.ToString());
        }

        {
            var memoryAccessor = new Arm64RegisterWExtendMemoryAccessor(Arm64RegisterX.X3, Arm64RegisterW.W1, new(new IArm64ExtendKind.LSL(), 4));
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, memoryAccessor.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, memoryAccessor.BaseRegister);
            Assert.IsTrue(memoryAccessor.HasExtend);
            Assert.AreEqual(new(new IArm64ExtendKind.LSL(), 4), memoryAccessor.Extend);
            Assert.IsTrue(memoryAccessor.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterW.W1, memoryAccessor.IndexRegister);
            Assert.IsFalse(memoryAccessor.HasImmediate);
            Assert.AreEqual(0, memoryAccessor.Immediate);
            Assert.IsFalse(memoryAccessor.IsPreIncrement);
            Assert.IsFalse(memoryAccessor.HasOptionalOffset);
            Assert.AreEqual("[x3, w1, lsl #4]", memoryAccessor.ToString());

            var pre = memoryAccessor.Pre;
            Assert.AreEqual(Arm64MemoryBaseRegisterKind.RegisterXOrSP, pre.BaseRegisterKind);
            Assert.AreEqual(Arm64RegisterX.X3, pre.BaseRegister);
            Assert.IsTrue(pre.HasExtend);
            Assert.AreEqual(new(new IArm64ExtendKind.LSL(), 4), pre.Extend);
            Assert.IsTrue(pre.HasIndexRegister);
            Assert.AreEqual(Arm64RegisterW.W1, pre.IndexRegister);
            Assert.IsFalse(pre.HasImmediate);
            Assert.AreEqual(0, pre.Immediate);
            Assert.IsTrue(pre.IsPreIncrement);
            Assert.IsFalse(pre.HasOptionalOffset);
            Assert.AreEqual("[x3, w1, lsl #4]!", pre.ToString());
        }
    }
}