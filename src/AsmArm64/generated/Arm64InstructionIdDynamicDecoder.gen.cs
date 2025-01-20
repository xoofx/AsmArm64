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

namespace AsmArm64;

static partial class Arm64InstructionIdDynamicDecoder
{
    public static Arm64InstructionId ResolveBetterAlias(Arm64InstructionId id, Arm64RawInstruction rawValue)
        => id switch
        {
            Arm64InstructionId.BFM_32m_bitfield => Resolve_BFM_32m_bitfield(rawValue),
            Arm64InstructionId.BFM_64m_bitfield => Resolve_BFM_64m_bitfield(rawValue),
            Arm64InstructionId.CSINC_32_condsel => Resolve_CSINC_32_condsel(rawValue),
            Arm64InstructionId.CSINC_64_condsel => Resolve_CSINC_64_condsel(rawValue),
            Arm64InstructionId.CSINV_32_condsel => Resolve_CSINV_32_condsel(rawValue),
            Arm64InstructionId.CSINV_64_condsel => Resolve_CSINV_64_condsel(rawValue),
            Arm64InstructionId.CSNEG_32_condsel => Resolve_CSNEG_32_condsel(rawValue),
            Arm64InstructionId.CSNEG_64_condsel => Resolve_CSNEG_64_condsel(rawValue),
            Arm64InstructionId.EXTR_32_extract => Resolve_EXTR_32_extract(rawValue),
            Arm64InstructionId.EXTR_64_extract => Resolve_EXTR_64_extract(rawValue),
            Arm64InstructionId.MOVN_32_movewide => Resolve_MOVN_32_movewide(rawValue),
            Arm64InstructionId.MOVN_64_movewide => Resolve_MOVN_64_movewide(rawValue),
            Arm64InstructionId.MOVZ_32_movewide => Resolve_MOVZ_32_movewide(rawValue),
            Arm64InstructionId.MOVZ_64_movewide => Resolve_MOVZ_64_movewide(rawValue),
            Arm64InstructionId.SBFM_32m_bitfield => Resolve_SBFM_32m_bitfield(rawValue),
            Arm64InstructionId.SBFM_64m_bitfield => Resolve_SBFM_64m_bitfield(rawValue),
            Arm64InstructionId.SYS_cr_systeminstrs => Resolve_SYS_cr_systeminstrs(rawValue),
            Arm64InstructionId.UBFM_32m_bitfield => Resolve_UBFM_32m_bitfield(rawValue),
            Arm64InstructionId.UBFM_64m_bitfield => Resolve_UBFM_64m_bitfield(rawValue),
            Arm64InstructionId.ORR_asimdsame_only => Resolve_ORR_asimdsame_only(rawValue),
            _ => throw new InvalidOperationException($"Invalid instruction id {id} not supported by dynamic better alias resolution")
        };
    
    /// <summary>
    /// Condition: UInt(imms) &lt; UInt(immr) => BFI_bfm_32m_bitfield
    /// Condition: UInt(imms) >= UInt(immr) => BFXIL_bfm_32m_bitfield
    /// </summary>
    private static partial Arm64InstructionId Resolve_BFM_32m_bitfield(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: UInt(imms) &lt; UInt(immr) => BFI_bfm_64m_bitfield
    /// Condition: UInt(imms) >= UInt(immr) => BFXIL_bfm_64m_bitfield
    /// </summary>
    private static partial Arm64InstructionId Resolve_BFM_64m_bitfield(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => CINC_csinc_32_condsel
    /// </summary>
    private static partial Arm64InstructionId Resolve_CSINC_32_condsel(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => CINC_csinc_64_condsel
    /// </summary>
    private static partial Arm64InstructionId Resolve_CSINC_64_condsel(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => CINV_csinv_32_condsel
    /// </summary>
    private static partial Arm64InstructionId Resolve_CSINV_32_condsel(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => CINV_csinv_64_condsel
    /// </summary>
    private static partial Arm64InstructionId Resolve_CSINV_64_condsel(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => CNEG_csneg_32_condsel
    /// </summary>
    private static partial Arm64InstructionId Resolve_CSNEG_32_condsel(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => CNEG_csneg_64_condsel
    /// </summary>
    private static partial Arm64InstructionId Resolve_CSNEG_64_condsel(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => ROR_extr_32_extract
    /// </summary>
    private static partial Arm64InstructionId Resolve_EXTR_32_extract(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rn == Rm => ROR_extr_64_extract
    /// </summary>
    private static partial Arm64InstructionId Resolve_EXTR_64_extract(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: !(IsZero(imm16) &amp;&amp; hw != '00') &amp;&amp; !IsOnes(imm16) => MOV_movn_32_movewide
    /// </summary>
    private static partial Arm64InstructionId Resolve_MOVN_32_movewide(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: !(IsZero(imm16) &amp;&amp; hw != '00') => MOV_movn_64_movewide
    /// </summary>
    private static partial Arm64InstructionId Resolve_MOVN_64_movewide(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: !(IsZero(imm16) &amp;&amp; hw != '00') => MOV_movz_32_movewide
    /// </summary>
    private static partial Arm64InstructionId Resolve_MOVZ_32_movewide(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: !(IsZero(imm16) &amp;&amp; hw != '00') => MOV_movz_64_movewide
    /// </summary>
    private static partial Arm64InstructionId Resolve_MOVZ_64_movewide(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: UInt(imms) &lt; UInt(immr) => SBFIZ_sbfm_32m_bitfield
    /// Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => SBFX_sbfm_32m_bitfield
    /// </summary>
    private static partial Arm64InstructionId Resolve_SBFM_32m_bitfield(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: UInt(imms) &lt; UInt(immr) => SBFIZ_sbfm_64m_bitfield
    /// Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => SBFX_sbfm_64m_bitfield
    /// </summary>
    private static partial Arm64InstructionId Resolve_SBFM_64m_bitfield(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: SysOp(op1, '0111', CRm, op2) == Sys_DC => DC_sys_cr_systeminstrs
    /// Condition: SysOp(op1, '0111', CRm, op2) == Sys_IC => IC_sys_cr_systeminstrs
    /// </summary>
    private static partial Arm64InstructionId Resolve_SYS_cr_systeminstrs(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: UInt(imms) + 1 == UInt(immr) => LSL_ubfm_32m_bitfield
    /// Condition: UInt(imms) &lt; UInt(immr) => UBFIZ_ubfm_32m_bitfield
    /// Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => UBFX_ubfm_32m_bitfield
    /// </summary>
    private static partial Arm64InstructionId Resolve_UBFM_32m_bitfield(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: UInt(imms) + 1 == UInt(immr) => LSL_ubfm_64m_bitfield
    /// Condition: UInt(imms) &lt; UInt(immr) => UBFIZ_ubfm_64m_bitfield
    /// Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => UBFX_ubfm_64m_bitfield
    /// </summary>
    private static partial Arm64InstructionId Resolve_UBFM_64m_bitfield(Arm64RawInstruction rawValue);
    /// <summary>
    /// Condition: Rm == Rn => MOV_orr_asimdsame_only
    /// </summary>
    private static partial Arm64InstructionId Resolve_ORR_asimdsame_only(Arm64RawInstruction rawValue);
}
