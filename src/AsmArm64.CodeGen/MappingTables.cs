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
        { "BFC_bfm_32m_bitfield", new() { { "lsb", _32_Minus_Value_Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFC_bfm_64m_bitfield", new() { { "lsb", _64_Minus_Value_Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFI_bfm_32m_bitfield", new() { { "lsb", _32_Minus_Value_Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "BFI_bfm_64m_bitfield", new() { { "lsb", _64_Minus_Value_Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
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
        { "LSL_ubfm_32m_bitfield", new() { { "shift", _32_Minus_Value_Mod32} }},
        { "LSL_ubfm_64m_bitfield", new() { { "shift", _64_Minus_Value_Mod64} }},
        { "SBFIZ_sbfm_32m_bitfield", new() { { "lsb", _32_Minus_Value_Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "SBFIZ_sbfm_64m_bitfield", new() { { "lsb", _64_Minus_Value_Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "SBFX_sbfm_32m_bitfield" , new() { { "width", ValuePlus1ShiftLeft6 } }},
        { "SBFX_sbfm_64m_bitfield" , new() { { "width", ValuePlus1ShiftLeft6 } }},
        { "STP_32_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "STP_64_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "STP_d_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "STP_q_ldstpair_post", new() { { "imm", ValueDivideBy16 } } },
        { "STP_s_ldstpair_post", new() { { "imm", ValueDivideBy4 } } },
        { "STTP_64_ldstpair_post", new() { { "imm", ValueDivideBy8 } } },
        { "STTP_q_ldstpair_post", new() { { "imm", ValueDivideBy16 } } },
        { "UBFIZ_ubfm_32m_bitfield", new() { { "lsb", _32_Minus_Value_Mod32 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "UBFIZ_ubfm_64m_bitfield", new() { { "lsb", _64_Minus_Value_Mod64 }, { "width", ValuePlus1ShiftLeft6 } } },
        { "UBFX_ubfm_32m_bitfield" , new() { { "width", ValueMod64Plus1 } }},
        { "UBFX_ubfm_64m_bitfield" , new() { { "width", ValueMod64Plus1 } }},

        // fcvtzs_float_fix.xml
        { "FCVTZS_32h_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZS_32s_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZS_32d_float2fix", new() { { "fbits", _64_Minus_Value } }},

        { "FCVTZS_64h_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZS_64s_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZS_64d_float2fix", new() { { "fbits", _64_Minus_Value } }},

        // fcvtzu_float_fix.xml
        { "FCVTZU_32h_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZU_32s_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZU_32d_float2fix", new() { { "fbits", _64_Minus_Value } }},

        { "FCVTZU_64h_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZU_64s_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "FCVTZU_64d_float2fix", new() { { "fbits", _64_Minus_Value } }},

        // scvtf_float_fix.xml
        { "SCVTF_h32_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "SCVTF_s32_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "SCVTF_d32_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "SCVTF_h64_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "SCVTF_s64_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "SCVTF_d64_float2fix", new() { { "fbits", _64_Minus_Value } }},

        // ucvtf_float_fix.xml
        { "UCVTF_h32_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "UCVTF_s32_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "UCVTF_d32_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "UCVTF_h64_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "UCVTF_s64_float2fix", new() { { "fbits", _64_Minus_Value } }},
        { "UCVTF_d64_float2fix", new() { { "fbits", _64_Minus_Value } }},

        { "STP_s_ldstpair_pre", new() { { "imm", ValueDivideBy4 } }},
        { "STNP_s_ldstnapair_offs", new() { { "imm", ValueDivideBy4 } }},
        { "STP_32_ldstpair_pre", new() { { "imm", ValueDivideBy4 } }},
        { "STNP_32_ldstnapair_offs", new() { { "imm", ValueDivideBy4 } }},
        { "STP_32_ldstpair_off", new() { { "imm", ValueDivideBy4 } }},

        { "STP_q_ldstpair_pre", new() { { "imm", ValueDivideBy16 } }},
        { "STNP_q_ldstnapair_offs", new() { { "imm", ValueDivideBy16 } }},
        { "STP_q_ldstpair_off", new() { { "imm", ValueDivideBy16 } }},

        { "LDR_32_ldst_pos", new() { { "pimm", ValueDivideBy4 } }},
        { "STRH_32_ldst_pos", new() { { "pimm", ValueDivideBy2 } }},
        { "LDPSW_64_ldstpair_pre", new() { { "imm", ValueDivideBy4 } }},
        { "LDPSW_64_ldstpair_off", new() { { "imm", ValueDivideBy4 } }},

        { "STR_q_ldst_pos", new() { { "pimm", ValueDivideBy16 } }},
        
        { "LDR_64_ldst_pos", new() { { "pimm", ValueDivideBy8 } }},
        { "LDRSW_64_ldst_pos", new() { { "pimm", ValueDivideBy4 } }},

        { "STR_32_ldst_pos", new() { { "pimm", ValueDivideBy4 } }},
        { "LDP_64_ldstpair_pre", new() { { "imm", ValueDivideBy8 } }},
        { "LDNP_64_ldstnapair_offs", new() { { "imm", ValueDivideBy8 } }},
        { "LDP_64_ldstpair_off", new() { { "imm", ValueDivideBy8 } }},

        { "LDNP_d_ldstnapair_offs", new() { { "imm", ValueDivideBy8 } }},
        { "LDP_d_ldstpair_off", new() { { "imm", ValueDivideBy8 } }},
        { "LDP_d_ldstpair_pre", new() { { "imm", ValueDivideBy8 } }},

        { "LDP_32_ldstpair_pre", new() { { "imm", ValueDivideBy4 } }},
        { "LDNP_32_ldstnapair_offs", new() { { "imm", ValueDivideBy4 } }},
        { "LDP_32_ldstpair_off", new() { { "imm", ValueDivideBy4 } }},

        { "LDR_h_ldst_pos", new() { { "pimm", ValueDivideBy2 } }},
        { "LDR_s_ldst_pos", new() { { "pimm", ValueDivideBy4 } }},

        { "LDRSH_32_ldst_pos", new() { { "pimm", ValueDivideBy2 } }},

        { "LDR_d_ldst_pos", new() { { "pimm", ValueDivideBy8 } }},

        { "LDRSH_64_ldst_pos", new() { { "pimm", ValueDivideBy2 } }},

        { "LDRAB_64w_ldst_pac", new() { { "simm", ValueDivideBy8 } }},
        { "LDRAA_64w_ldst_pac", new() { { "simm", ValueDivideBy8 } }},
        { "LDRAB_64_ldst_pac", new() { { "simm", ValueDivideBy8 } }},
        { "LDRAA_64_ldst_pac", new() { { "simm", ValueDivideBy8 } }},

        { "STP_d_ldstpair_pre", new() { { "imm", ValueDivideBy8 } }},
        { "STNP_d_ldstnapair_offs", new() { { "imm", ValueDivideBy8 } }},
        { "STP_d_ldstpair_off", new() { { "imm", ValueDivideBy8 } }},

        { "STP_s_ldstpair_off", new() { { "imm", ValueDivideBy4 } }},

        { "LDP_q_ldstpair_pre", new() { { "imm", ValueDivideBy16 } }},
        { "LDP_q_ldstpair_off", new() { { "imm", ValueDivideBy16 } }},

        { "AND_32_log_imm", new() { { "imm", DecodeBitMask32 } }},
        { "ANDS_32s_log_imm", new() { { "imm", DecodeBitMask32 } }},
        { "AND_64_log_imm", new() { { "imm", DecodeBitMask64 } }},
        { "ANDS_64s_log_imm", new() { { "imm", DecodeBitMask64 } }},
        { "ORR_32_log_imm", new() { { "imm", DecodeBitMask32 } }},
        { "ORR_64_log_imm", new() { { "imm", DecodeBitMask64 } }},

        { "MOV_orr_32_log_imm", new() { { "imm", DecodeBitMask32 } }},
        { "MOV_orr_64_log_imm", new() { { "imm", DecodeBitMask64 } }},
        
        { "EOR_32_log_imm", new() { { "imm", DecodeBitMask32 } }},
        { "EOR_64_log_imm", new() { { "imm", DecodeBitMask64 } }},

        { "TST_ands_32s_log_imm", new() { { "imm", DecodeBitMask32 } }},
        { "TST_ands_64s_log_imm", new() { { "imm", DecodeBitMask64 } }},

        { "STG_64spre_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STZ2G_64spre_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "ST2G_64spre_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STZG_64soffset_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STG_64soffset_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STZ2G_64soffset_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "ST2G_64soffset_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STZG_64spost_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STG_64spost_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STZ2G_64spost_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "ST2G_64spost_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        { "STGP_64_ldstpair_off", new() { { "imm", ValueDivideBy16 } }},
        { "STGP_64_ldstpair_post", new() { { "imm", ValueDivideBy16 } }},
        { "STGP_64_ldstpair_pre", new() { { "imm", ValueDivideBy16 } }},
        { "STZG_64spre_ldsttags", new() { { "simm", ValueDivideBy16 } }},

        { "LDG_64loffset_ldsttags", new() { { "simm", ValueDivideBy16 } }},
        
        { "ADDG_64_addsub_immtags", new() { { "uimm6", ValueDivideBy16 } }},
        { "SUBG_64_addsub_immtags", new() { { "uimm6", ValueDivideBy16 } }},


        { "SRSRA_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "SRI_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "SSRA_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "SSHR_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "USRA_asisdshf_r", new() { { "shift", _128_Minus_Value } }},

        { "URSHR_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "USHR_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "URSRA_asisdshf_r", new() { { "shift", _128_Minus_Value } }},
        { "SRSHR_asisdshf_r", new() { { "shift", _128_Minus_Value } }},

        { "SLI_asisdshf_r", new() { { "shift", Value_Minus_64 } }},
        { "SHL_asisdshf_r", new() { { "shift", Value_Minus_64 } }},


        { "MOVI_asimdimm_d_ds", new() { { "imm", ValueImm64 } }},
        { "MOVI_asimdimm_d2_d", new() { { "imm", ValueImm64 } }},

        { "MSR_si_pstate", new() { { "imm", ValueMsrImmediate } }},


        { "PRFM_p_ldst_pos", new() { { "pimm", ValueDivideBy8 } }},

        { "MOV_movn_32_movewide", new() { { "imm", InvertValueShiftWide32 } }},
        { "MOV_movz_64_movewide", new() { { "imm", ValueShiftWide64 } }},
        { "MOV_movz_32_movewide", new() { { "imm", ValueShiftWide64 } }},

        // LSL_ubfm_32m_bitfield => UBFM  <Wd>, <Wn>, #(-<shift>  MOD  32), #(31-<shift>)
        // LSL_ubfm_64m_bitfield => UBFM  <Xd>, <Xn>, #(-<shift>  MOD  64), #(63-<shift>)
        // SBFX_sbfm_32m_bitfield       width     #(<lsb>+<width>-1)
        // SBFX_sbfm_64m_bitfield       width     #(<lsb>+<width>-1)
        // UBFX_ubfm_32m_bitfield => UBFM  <Wd>, <Wn>, #<lsb>, #(<lsb>+<width>-1)
        // UBFX_ubfm_64m_bitfield => UBFM  <Xd>, <Xn>, #<lsb>, #(<lsb>+<width>-1)
    };
}