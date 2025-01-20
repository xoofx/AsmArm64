// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace AsmArm64;

/// <summary>
/// Manual decoding of some instructions to resolve better alias.
/// </summary>
internal static partial class Arm64InstructionIdDynamicDecoder
{
    private static partial Arm64InstructionId Resolve_BFM_32m_bitfield(Arm64RawInstruction rawValue)
    {
        // Condition: UInt(imms) &lt; UInt(immr) => BFI_bfm_32m_bitfield
        // Condition: UInt(imms) >= UInt(immr) => BFXIL_bfm_32m_bitfield
        var imms = (rawValue >> 10) & 0b111111;
        var immr = (rawValue >> 16) & 0b111111;
        return imms < immr ? Arm64InstructionId.BFI_bfm_32m_bitfield : Arm64InstructionId.BFXIL_bfm_32m_bitfield;
    }

    private static partial Arm64InstructionId Resolve_BFM_64m_bitfield(Arm64RawInstruction rawValue)
    {
        // Condition: UInt(imms) &lt; UInt(immr) => BFI_bfm_64m_bitfield
        // Condition: UInt(imms) >= UInt(immr) => BFXIL_bfm_64m_bitfield
        var imms = (rawValue >> 10) & 0b111111;
        var immr = (rawValue >> 16) & 0b111111;
        return imms < immr ? Arm64InstructionId.BFI_bfm_64m_bitfield : Arm64InstructionId.BFXIL_bfm_64m_bitfield;
    }

    private static partial Arm64InstructionId Resolve_CSINC_32_condsel(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => CINC_csinc_32_condsel
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.CINC_csinc_32_condsel : Arm64InstructionId.CSINC_32_condsel;
    }

    private static partial Arm64InstructionId Resolve_CSINC_64_condsel(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => CINC_csinc_64_condsel
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.CINC_csinc_64_condsel : Arm64InstructionId.CSINC_64_condsel;
    }

    private static partial Arm64InstructionId Resolve_CSINV_32_condsel(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => CINV_csinv_32_condsel
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.CINV_csinv_32_condsel : Arm64InstructionId.CSINV_32_condsel;
    }

    private static partial Arm64InstructionId Resolve_CSINV_64_condsel(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => CINV_csinv_64_condsel
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.CINV_csinv_64_condsel : Arm64InstructionId.CSINV_64_condsel;
    }

    private static partial Arm64InstructionId Resolve_CSNEG_32_condsel(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => CNEG_csneg_32_condsel
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.CNEG_csneg_32_condsel : Arm64InstructionId.CSNEG_32_condsel;
    }

    private static partial Arm64InstructionId Resolve_CSNEG_64_condsel(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => CNEG_csneg_64_condsel
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.CNEG_csneg_64_condsel : Arm64InstructionId.CSNEG_64_condsel;
    }

    private static partial Arm64InstructionId Resolve_EXTR_32_extract(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => ROR_extr_32_extract
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.ROR_extr_32_extract : Arm64InstructionId.EXTR_32_extract;
    }

    private static partial Arm64InstructionId Resolve_EXTR_64_extract(Arm64RawInstruction rawValue)
    {
        // Condition: Rn == Rm => ROR_extr_64_extract
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.ROR_extr_64_extract : Arm64InstructionId.EXTR_64_extract;
    }

    private static partial Arm64InstructionId Resolve_MOVN_32_movewide(Arm64RawInstruction rawValue)
    {
        // Condition: !(IsZero(imm16) && hw != '00') && !IsOnes(imm16) => MOV_movn_32_movewide
        // imm16: 5:16
        // hw: 21:2
        var imm16 = (ushort)(rawValue >> 5);
        var hw = (rawValue >> 21) & 0x3;
        return !(imm16 == 0 && hw != 0) && imm16 != 0xFFFF ? Arm64InstructionId.MOV_movn_32_movewide : Arm64InstructionId.MOV_movz_32_movewide;
    }

    private static partial Arm64InstructionId Resolve_MOVN_64_movewide(Arm64RawInstruction rawValue)
    {
        // Condition: !(IsZero(imm16) &amp;&amp; hw != '00') => MOV_movn_64_movewide
        // imm16: 5:16
        // hw: 21:2
        var imm16 = (ushort)(rawValue >> 5);
        var hw = (rawValue >> 21) & 0x3;
        return !(imm16 == 0 && hw != 0) ? Arm64InstructionId.MOV_movn_64_movewide : Arm64InstructionId.MOV_movz_64_movewide;
    }

    private static partial Arm64InstructionId Resolve_MOVZ_32_movewide(Arm64RawInstruction rawValue)
    {
        // Condition: !(IsZero(imm16) &amp;&amp; hw != '00') => MOV_movz_32_movewide
        // imm16: 5:16
        // hw: 21:2
        var imm16 = (ushort)(rawValue >> 5);
        var hw = (rawValue >> 21) & 0x3;
        return !(imm16 == 0 && hw != 0) ? Arm64InstructionId.MOV_movz_32_movewide : Arm64InstructionId.MOV_movn_32_movewide;
    }

    private static partial Arm64InstructionId Resolve_MOVZ_64_movewide(Arm64RawInstruction rawValue)
    {
        // Condition: !(IsZero(imm16) &amp;&amp; hw != '00') => MOV_movz_64_movewide
        // imm16: 5:16
        // hw: 21:2
        var imm16 = (ushort)(rawValue >> 5);
        var hw = (rawValue >> 21) & 0x3;
        return !(imm16 == 0 && hw != 0) ? Arm64InstructionId.MOV_movz_64_movewide : Arm64InstructionId.MOV_movn_64_movewide;
    }

    private static partial Arm64InstructionId Resolve_SBFM_32m_bitfield(Arm64RawInstruction rawValue)
    {
        // Condition: UInt(imms) &lt; UInt(immr) => SBFIZ_sbfm_32m_bitfield
        // Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => SBFX_sbfm_32m_bitfield
        var imms = (rawValue >> 10) & 0b111111;
        var immr = (rawValue >> 16) & 0b111111;
        if (imms < immr)
        {
            return Arm64InstructionId.SBFIZ_sbfm_32m_bitfield;
        }
        var sf = (rawValue >> 31) & 1;
        var opc = (rawValue >> 29) & 3;
        return BFXPreferred(sf, opc, imms, immr) ? Arm64InstructionId.SBFX_sbfm_32m_bitfield : Arm64InstructionId.SBFM_32m_bitfield;
    }

    private static partial Arm64InstructionId Resolve_SBFM_64m_bitfield(Arm64RawInstruction rawValue)
    {
        // Condition: UInt(imms) &lt; UInt(immr) => SBFIZ_sbfm_64m_bitfield
        // Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => SBFX_sbfm_64m_bitfield
        var imms = (rawValue >> 10) & 0b111111;
        var immr = (rawValue >> 16) & 0b111111;
        if (imms < immr)
        {
            return Arm64InstructionId.SBFIZ_sbfm_64m_bitfield;
        }
        var sf = (rawValue >> 31) & 1;
        var opc = (rawValue >> 29) & 3;
        return BFXPreferred(sf, opc, imms, immr) ? Arm64InstructionId.SBFX_sbfm_64m_bitfield : Arm64InstructionId.SBFM_64m_bitfield;
    }

    private static partial Arm64InstructionId Resolve_SYS_cr_systeminstrs(Arm64RawInstruction rawValue)
    {
        // Condition: SysOp(op1, '0111', CRm, op2) == Sys_DC => DC_sys_cr_systeminstrs
        // Condition: SysOp(op1, '0111', CRm, op2) == Sys_IC => IC_sys_cr_systeminstrs
        // TODO:
        return Arm64InstructionId.SYS_cr_systeminstrs;
    }

    private static partial Arm64InstructionId Resolve_UBFM_32m_bitfield(Arm64RawInstruction rawValue)
    {
        // Condition: UInt(imms) + 1 == UInt(immr) => LSL_ubfm_32m_bitfield
        // Condition: UInt(imms) &lt; UInt(immr) => UBFIZ_ubfm_32m_bitfield
        // Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => UBFX_ubfm_32m_bitfield
        var imms = (rawValue >> 10) & 0b111111;
        var immr = (rawValue >> 16) & 0b111111;
        if (imms + 1 == immr)
        {
            return Arm64InstructionId.LSL_ubfm_32m_bitfield;
        }

        if (imms < immr)
        {
            return Arm64InstructionId.UBFIZ_ubfm_32m_bitfield;
        }

        var sf = (rawValue >> 31) & 1;
        var opc = (rawValue >> 29) & 3;
        return BFXPreferred(sf, opc, imms, immr) ? Arm64InstructionId.UBFX_ubfm_32m_bitfield : Arm64InstructionId.UBFM_32m_bitfield;
    }

    private static partial Arm64InstructionId Resolve_UBFM_64m_bitfield(Arm64RawInstruction rawValue)
    {
        // Condition: UInt(imms) + 1 == UInt(immr) => LSL_ubfm_64m_bitfield
        // Condition: UInt(imms) &lt; UInt(immr) => UBFIZ_ubfm_64m_bitfield
        // Condition: BFXPreferred(sf, opc&lt;1>, imms, immr) => UBFX_ubfm_64m_bitfield
        var imms = (rawValue >> 10) & 0b111111;
        var immr = (rawValue >> 16) & 0b111111;
        if (imms + 1 == immr)
        {
            return Arm64InstructionId.LSL_ubfm_64m_bitfield;
        }

        if (imms < immr)
        {
            return Arm64InstructionId.UBFIZ_ubfm_64m_bitfield;
        }

        var sf = (rawValue >> 31) & 1;
        var opc = (rawValue >> 29) & 3;
        return BFXPreferred(sf, opc, imms, immr) ? Arm64InstructionId.UBFX_ubfm_64m_bitfield : Arm64InstructionId.UBFM_64m_bitfield;
    }

    private static partial Arm64InstructionId Resolve_ORR_asimdsame_only(Arm64RawInstruction rawValue)
    {
        // Condition: Rm == Rn => MOV_orr_asimdsame_only
        var rn = Reg(rawValue, 5);
        var rm = Reg(rawValue, 16);
        return (rn == rm) ? Arm64InstructionId.MOV_orr_asimdsame_only : Arm64InstructionId.ORR_asimdsame_only;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Reg(Arm64RawInstruction rawValue, int shift) => (rawValue >> shift) & 0x1F;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool BFXPreferred(uint sf, uint uns, uint imms, uint immr)
    {
        // boolean <a id="impl-aarch64.BFXPreferred.4"/>BFXPreferred(bit sf, bit uns, bits(6) imms, bits(6) immr)
        // // must not match UBFIZ/SBFIX alias
        // if <a href="shared_pseudocode.html#impl-shared.UInt.1" title="function: integer UInt(bits(N) x)">UInt</a>(imms) &lt; <a href="shared_pseudocode.html#impl-shared.UInt.1" title="function: integer UInt(bits(N) x)">UInt</a>(immr) then
        //     return FALSE;
        // // must not match LSR/ASR/LSL alias (imms == 31 or 63)
        if (imms < immr)
        {
            return false;
        }
        // if imms == sf:'11111' then
        //     return FALSE;
        if (imms == (byte)((byte)(sf << 5) | (byte)0x1F))
        {
            return false;
        }
        // // must not match UXTx/SXTx alias
        // if immr == '000000' then
        if (immr == 0)
        {
            //     // must not match 32-bit UXT[BH] or SXT[BH]
            //     if sf == '0' &amp;&amp; imms IN {'000111', '001111'} then
            //         return FALSE;
            if (sf == 0 && (imms == 7 || imms == 15))
            {
                return false;
            }
            //     // must not match 64-bit SXT[BHW]
            //     if sf:uns == '10' &amp;&amp; imms IN {'000111', '001111', '011111'} then
            //         return FALSE;
            if (sf == 1 && uns == 0 && (imms == 7 || imms == 15 || imms == 31))
            {
                return false;
            }
            // // must be UBFX/SBFX alias
        }
        // return TRUE;</p>
        return true;
    }
}