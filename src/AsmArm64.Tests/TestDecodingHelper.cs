// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Xml.Serialization;

namespace AsmArm64.Tests;

[TestClass]
public class TestDecodingHelper
{
    [TestMethod]
    public void TestBitRange1()
    {
        var value = Arm64DecodingHelper.GetBitRange1(0x1F, 0, 5, 0);
        Assert.AreEqual(0x1F, value);

        value = Arm64DecodingHelper.GetBitRange1(0x1F, 0, 5, 1);
        Assert.AreEqual(-1, value);
    }

    [TestMethod]
    public void TestBitRange2()
    {
        var value = Arm64DecodingHelper.GetBitRange2(0x1001F, 16, 1, 0, 5, 0);
        Assert.AreEqual(0x3F, value);

        value = Arm64DecodingHelper.GetBitRange2(0x1001F, 16, 1, 0, 5, 1);
        Assert.AreEqual(-1, value);
    }

    [TestMethod]
    public void TestLogicalImmediate64()
    {
        {
            var src = 0x03030303_03030303UL;
            var value = Arm64LogicalImmediateHelper.EncodeLogicalImmediate64(src);
            var decoded = Arm64LogicalImmediateHelper.DecodeLogicalImmediate64((uint)value);
            Assert.AreEqual(src, decoded);
        }

        {
            for (int i = 0; i < 63; i++)
            {
                var src = 0xFFFFUL << i;
                var value = Arm64LogicalImmediateHelper.EncodeLogicalImmediate64(src);
                var decoded = Arm64LogicalImmediateHelper.DecodeLogicalImmediate64((uint)value);
                Assert.AreEqual(src, decoded);
            }
        }
    }
    
    [TestMethod]
    public void TestLogicalImmediate32()
    {
        {
            var src = 0x03030303U;
            var value = Arm64LogicalImmediateHelper.EncodeLogicalImmediate32(src);
            var decoded = Arm64LogicalImmediateHelper.DecodeLogicalImmediate32((uint)value);
            Assert.AreEqual(src, decoded);
        }

        {
            for (int i = 0; i < 31; i++)
            {
                var src = 0xFFFFU << i;
                var value = Arm64LogicalImmediateHelper.EncodeLogicalImmediate32(src);
                var decoded = Arm64LogicalImmediateHelper.DecodeLogicalImmediate32((uint)value);
                Assert.AreEqual(src, decoded);
            }
        }
    }

    [TestMethod]
    public void TestFloatImmediate()
    {
        for (int i = 0; i <= 255; i++)
        {
            var src = (byte)i;
            var value = Arm64FloatImmediate.DecodeAsFloat(src);
            var encoded = Arm64FloatImmediate.Encode(value);
            Assert.AreEqual(src, encoded.Value);
            //Console.WriteLine($"0x{src:X2} -> {value} ({encoded})");
        }

        Assert.AreEqual(1.0f, Arm64FloatImmediate.Value1.AsFloat());
        Assert.AreEqual(2.0f, Arm64FloatImmediate.Value2.AsFloat());
        Assert.AreEqual(3.0f, Arm64FloatImmediate.Value3.AsFloat());
        Assert.AreEqual(0.5f, Arm64FloatImmediate.ValueZeroDot5.AsFloat());
    }


    [TestMethod]
    public void TestBitMaskImmediate64()
    {
        for (int i = 0; i <= 255; i++)
        {
            var src = (byte)i;
            var value = Arm64BitMaskImmediate64.DecodeAsMask(src);
            var encoded = Arm64BitMaskImmediate64.Encode(value);
            Assert.AreEqual(src, encoded.Value);
        }

        {
            var value = Arm64BitMaskImmediate64.DecodeAsMask(0x85);
            Assert.AreEqual(0xFF_00_00_00__00_FF_00_FF.ToString("X16"), value.ToString("X16"));
        }
    }
}