// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Extensions for ARM64 classes and enums.
/// </summary>
public static partial class Arm64Extensions
{
    private static readonly string[] ShiftTypeLower =
    [
        "lsl",
        "lsr",
        "asr",
        "ror",
        "msl",
        "???"
    ];

    private static readonly string[] ShiftTypeUpper =
    [
        "LSL",
        "LSR",
        "ASR",
        "ROR",
        "MSL",
        "???"
    ];
    
    /// <summary>
    /// Gets the text representation of the specified <see cref="Arm64Mnemonic"/>.
    /// </summary>
    /// <param name="mnemonic">The mnemonic.</param>
    /// <param name="upperCase">A flag indicating whether to format the mnemonic in upper case or lower case.</param>
    /// <returns>The upper text representation of the specified <see cref="Arm64Mnemonic"/>.</returns>
    public static string ToText(this Arm64Mnemonic mnemonic, bool upperCase = false) => upperCase ? MnemonicUpperTable[(int)mnemonic] : MnemonicLowerTable[(int)mnemonic];

    /// <summary>
    /// Gets the text representation of the specified <see cref="Arm64ShiftKind"/>.
    /// </summary>
    /// <param name="shiftType"></param>
    /// <param name="upperCase"></param>
    /// <returns></returns>
    public static string ShiftToText<T>(this T shiftType, bool upperCase = false) where T : IArm64ShiftKind
        => upperCase ? ShiftTypeUpper[(int)shiftType.ShiftKind] : ShiftTypeLower[(int)shiftType.ShiftKind];


    /// <summary>
    /// Gets the text representation of the specified <see cref="Arm64ShiftKind"/>.
    /// </summary>
    /// <param name="shiftKind"></param>
    /// <param name="upperCase"></param>
    /// <returns></returns>
    public static string ToText(this Arm64ShiftKind shiftKind, bool upperCase = false)
        => upperCase ? ShiftTypeUpper[(int)shiftKind] : ShiftTypeLower[(int)shiftKind];

    /// <summary>
    /// Validates the range of a register index.
    /// </summary>
    /// <param name="index">The register index.</param>
    /// <returns>The register index if it is valid.</returns>
    private static int ValidateRegisterIndex(int index) => index is >= 0 and < 32 ? index : ThrowRegisterIndexOutOfRange(index);
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static int ThrowRegisterIndexOutOfRange(int index)
    {
        throw new InvalidOperationException($"Invalid register index {index}. The index must be in the range [0, 31]");
    }

    /// <summary>
    /// Detects if the instruction is a branch instruction.
    /// </summary>
    /// <param name="id">The instruction id</param>
    /// <returns><c>true</c> if the instruction is a branch instruction; otherwise, <c>false</c>.</returns>
    public static bool IsBranch(this Arm64InstructionId id)
    {
        switch (id)
        {
            case Arm64InstructionId.B_only_branch_imm:
            case Arm64InstructionId.B_only_condbranch:
            case Arm64InstructionId.BC_only_condbranch:
            case Arm64InstructionId.BL_only_branch_imm:
            case Arm64InstructionId.BLR_64_branch_reg:
            case Arm64InstructionId.BLRAA_64p_branch_reg:
            case Arm64InstructionId.BLRAAZ_64_branch_reg:
            case Arm64InstructionId.BLRAB_64p_branch_reg:
            case Arm64InstructionId.BLRABZ_64_branch_reg:
            case Arm64InstructionId.BR_64_branch_reg:
            case Arm64InstructionId.BRAA_64p_branch_reg:
            case Arm64InstructionId.BRAAZ_64_branch_reg:
            case Arm64InstructionId.BRAB_64p_branch_reg:
            case Arm64InstructionId.BRABZ_64_branch_reg:
            case Arm64InstructionId.CBGT_32_imm:
            case Arm64InstructionId.CBLT_32_imm:
            case Arm64InstructionId.CBHI_32_imm:
            case Arm64InstructionId.CBLO_32_imm:
            case Arm64InstructionId.CBEQ_32_imm:
            case Arm64InstructionId.CBNE_32_imm:
            case Arm64InstructionId.CBGT_64_imm:
            case Arm64InstructionId.CBLT_64_imm:
            case Arm64InstructionId.CBHI_64_imm:
            case Arm64InstructionId.CBLO_64_imm:
            case Arm64InstructionId.CBEQ_64_imm:
            case Arm64InstructionId.CBNE_64_imm:
            case Arm64InstructionId.CBGT_32_regs:
            case Arm64InstructionId.CBGE_32_regs:
            case Arm64InstructionId.CBHI_32_regs:
            case Arm64InstructionId.CBHS_32_regs:
            case Arm64InstructionId.CBEQ_32_regs:
            case Arm64InstructionId.CBNE_32_regs:
            case Arm64InstructionId.CBGT_64_regs:
            case Arm64InstructionId.CBGE_64_regs:
            case Arm64InstructionId.CBHI_64_regs:
            case Arm64InstructionId.CBHS_64_regs:
            case Arm64InstructionId.CBEQ_64_regs:
            case Arm64InstructionId.CBNE_64_regs:
            case Arm64InstructionId.CBBGT_8_regs:
            case Arm64InstructionId.CBBGE_8_regs:
            case Arm64InstructionId.CBBHI_8_regs:
            case Arm64InstructionId.CBBHS_8_regs:
            case Arm64InstructionId.CBBEQ_8_regs:
            case Arm64InstructionId.CBBNE_8_regs:
            case Arm64InstructionId.CBBLE_cbbge_8_regs:
            case Arm64InstructionId.CBBLO_cbbhi_8_regs:
            case Arm64InstructionId.CBBLS_cbbhs_8_regs:
            case Arm64InstructionId.CBBLT_cbbgt_8_regs:
            case Arm64InstructionId.CBGE_cbgt_32_imm:
            case Arm64InstructionId.CBGE_cbgt_64_imm:
            case Arm64InstructionId.CBHGT_16_regs:
            case Arm64InstructionId.CBHGE_16_regs:
            case Arm64InstructionId.CBHHI_16_regs:
            case Arm64InstructionId.CBHHS_16_regs:
            case Arm64InstructionId.CBHEQ_16_regs:
            case Arm64InstructionId.CBHNE_16_regs:
            case Arm64InstructionId.CBHLE_cbhge_16_regs:
            case Arm64InstructionId.CBHLO_cbhhi_16_regs:
            case Arm64InstructionId.CBHLS_cbhhs_16_regs:
            case Arm64InstructionId.CBHLT_cbhgt_16_regs:
            case Arm64InstructionId.CBHS_cbhi_32_imm:
            case Arm64InstructionId.CBHS_cbhi_64_imm:
            case Arm64InstructionId.CBLE_cblt_32_imm:
            case Arm64InstructionId.CBLE_cblt_64_imm:
            case Arm64InstructionId.CBLE_cbge_32_regs:
            case Arm64InstructionId.CBLE_cbge_64_regs:
            case Arm64InstructionId.CBLO_cbhi_32_regs:
            case Arm64InstructionId.CBLO_cbhi_64_regs:
            case Arm64InstructionId.CBLS_cblo_32_imm:
            case Arm64InstructionId.CBLS_cblo_64_imm:
            case Arm64InstructionId.CBLS_cbhs_32_regs:
            case Arm64InstructionId.CBLS_cbhs_64_regs:
            case Arm64InstructionId.CBLT_cbgt_32_regs:
            case Arm64InstructionId.CBLT_cbgt_64_regs:
            case Arm64InstructionId.CBNZ_32_compbranch:
            case Arm64InstructionId.CBNZ_64_compbranch:
            case Arm64InstructionId.CBZ_32_compbranch:
            case Arm64InstructionId.CBZ_64_compbranch:
            case Arm64InstructionId.ERET_64e_branch_reg:
            case Arm64InstructionId.ERETAA_64e_branch_reg:
            case Arm64InstructionId.ERETAB_64e_branch_reg:
            case Arm64InstructionId.RET_64r_branch_reg:
            case Arm64InstructionId.RETAA_64e_branch_reg:
            case Arm64InstructionId.RETAB_64e_branch_reg:
            case Arm64InstructionId.RETAASPPC_only_miscbranch:
            case Arm64InstructionId.RETABSPPC_only_miscbranch:
            case Arm64InstructionId.RETAASPPCR_64m_branch_reg:
            case Arm64InstructionId.RETABSPPCR_64m_branch_reg:
            case Arm64InstructionId.TBNZ_only_testbranch:
            case Arm64InstructionId.TBZ_only_testbranch:
                return true;
            default:
                return false;
        }
    }
}