// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

using static Arm64Factory;

[TestClass]
public class Class1Test
{
    [TestMethod]
    public void TestSimple()
    {
        var x0 = X0;
        var x1 = X1;
        var sp = SP;
        var xzr = XZR;

        Console.WriteLine($"x0={x0}");
        Console.WriteLine($"x1={x1}");
        Console.WriteLine($"sp={sp}");
        Console.WriteLine($"xzr={xzr}");
    }
}
