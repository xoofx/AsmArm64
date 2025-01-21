// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.CodeGen;

using static Arm64ImmediateValueEncodingKind;
static class MappingTables
{
    public static bool TryGetImmediateEncoding(string instructionId, string operandName, out Arm64ImmediateValueEncodingKind encoding)
    {
        encoding = None;
        return MapInstructionImmediateValueToEncoding.TryGetValue(instructionId, out var map) && map.TryGetValue(operandName, out encoding);
    }

    private static readonly Dictionary<string, Dictionary<string, Arm64ImmediateValueEncodingKind>> MapInstructionImmediateValueToEncoding = new()
    {
        { "BFC_bfm_32m_bitfield", new() { { "lsb", MinusValuePlus32Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFC_bfm_64m_bitfield", new() { { "lsb", MinusValuePlus64Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFI_bfm_32m_bitfield", new() { { "lsb", MinusValuePlus32Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFI_bfm_64m_bitfield", new() { { "lsb", MinusValuePlus64Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFXIL_bfm_32m_bitfield" , new() { { "width", LsbPlusWidthMinus1 } }},
        { "BFXIL_bfm_64m_bitfield" , new() { { "width", LsbPlusWidthMinus1 } }},
        { "FMOV_asimdimm_d2_d", new() { { "imm", SignedFloatExp3Mantissa4 } } },
        { "FMOV_asimdimm_h_h", new() { { "imm", SignedFloatExp3Mantissa4 } } },
        { "FMOV_asimdimm_s_s", new() { { "imm", SignedFloatExp3Mantissa4 } } },
        { "FMOV_d_floatimm", new() { { "imm", SignedFloatExp3Mantissa4 } } },
        { "FMOV_h_floatimm", new() { { "imm", SignedFloatExp3Mantissa4 } } },
        { "FMOV_s_floatimm", new() { { "imm", SignedFloatExp3Mantissa4 } } },
        { "LDNP_s_ldstnapair_offs", new() { { "imm", ValueDivideBy4 } } },
        { "LDP_32_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "LDP_64_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "LDP_d_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "LDP_q_ldstpair_post", new() { { "imm", ValueDivideBy16 } } },
        { "LDP_s_ldstpair_pre", new() { { "imm", ValueDivideBy4 } } },
        { "LDP_s_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "LDP_s_ldstpair_off", new() { { "imm", ValueDivideBy4 } } },
        { "LDPSW_64_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "LDTP_64_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "LDTP_q_ldstpair_post", new() { { "imm", ValueDivideBy16 } } },
        { "LSL_ubfm_32m_bitfield", new() { { "lsb", MinusValuePlus32Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "LSL_ubfm_64m_bitfield", new() { { "lsb", MinusValuePlus64Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "SBFIZ_sbfm_32m_bitfield", new() { { "lsb", MinusValuePlus32Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "SBFIZ_sbfm_64m_bitfield", new() { { "lsb", MinusValuePlus64Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "SBFX_sbfm_32m_bitfield" , new() { { "width", ValuePlus1ShiftLeft6 } }},
        { "SBFX_sbfm_64m_bitfield" , new() { { "width", ValuePlus1ShiftLeft6 } }},
        { "STP_32_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "STP_64_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "STP_d_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "STP_q_ldstpair_post", new() { { "imm", ValueDivideBy16 } } },
        { "STP_s_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "STTP_64_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "STTP_q_ldstpair_post", new() { { "imm", ValueDivideBy16 } } },
        { "UBFIZ_ubfm_32m_bitfield", new() { { "lsb", MinusValuePlus32Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "UBFIZ_ubfm_64m_bitfield", new() { { "lsb", MinusValuePlus64Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "UBFX_ubfm_32m_bitfield" , new() { { "width", ValuePlus1ShiftLeft6 } }},
        { "UBFX_ubfm_64m_bitfield" , new() { { "width", ValuePlus1ShiftLeft6 } }},
        // LSL_ubfm_32m_bitfield => UBFM  <Wd>, <Wn>, #(-<shift>  MOD  32), #(31-<shift>)
        // LSL_ubfm_64m_bitfield => UBFM  <Xd>, <Xn>, #(-<shift>  MOD  64), #(63-<shift>)
        // SBFX_sbfm_32m_bitfield       width     #(<lsb>+<width>-1)
        // SBFX_sbfm_64m_bitfield       width     #(<lsb>+<width>-1)
        // UBFX_ubfm_32m_bitfield => UBFM  <Wd>, <Wn>, #<lsb>, #(<lsb>+<width>-1)
        // UBFX_ubfm_64m_bitfield => UBFM  <Xd>, <Xn>, #<lsb>, #(<lsb>+<width>-1)
    };
}