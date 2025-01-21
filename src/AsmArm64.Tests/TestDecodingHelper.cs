// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

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
}