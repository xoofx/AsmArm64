// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.CodeGen;

internal class Program
{
    static async Task Main(string[] args)
    {
        var isaTarGzUrl = "https://developer.arm.com/-/cdn-downloads/permalink/Exploration-Tools-A64-ISA/ISA_A64/ISA_A64_xml_A_profile-2024-12.tar.gz";
        var systemRegisterTarGzUrl = "https://developer.arm.com/-/cdn-downloads/permalink/Exploration-Tools-Arm-Architecture-System-Registers/SysReg/SysReg_xml_A_profile-2024-12.tar.gz";
        var capstoneTarGzUrl = "https://github.com/capstone-engine/capstone/archive/refs/tags/6.0.0-Alpha3.tar.gz";

        var processor = new Arm64Processor(isaTarGzUrl, systemRegisterTarGzUrl, capstoneTarGzUrl);
        await processor.Run();
    }
}