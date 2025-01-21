// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.CodeGen;

internal class Program
{
    static void Main(string[] args)
    {
        var processor = new Arm64Processor(@"C:\code\AsmArm64\tmp\ISA_A64_xml_A_profile-2024-12", @"C:\code\AsmArm64\tmp\SysReg_xml_A_profile-2024-12\SysReg_xml_A_profile-2024-12");
        processor.Run();
    }
}