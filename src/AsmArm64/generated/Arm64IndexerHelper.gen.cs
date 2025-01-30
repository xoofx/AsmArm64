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


using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Decode Indexer class.
/// </summary>
static class Arm64IndexerHelper
{
    public static bool TryDecode(Arm64RawInstruction rawValue, byte mapIndex, out int index)
    {
        switch (mapIndex)
        {
            // FMOV_64vx_float2int           : FMOV        Xd, Vn.D[1] <- Operand: Vn.D[1]
            // FMOV_v64i_float2int           : FMOV        Vd.D[1], Xn <- Operand: Vd.D[1]
            case 1:
            {
                index = 1;
                return true;
            }
            // LUTI4_asimdtbl_l5             : LUTI4       Vd.16B, {Vn.16B}, Vm[index] <- Operand: Vm[index]
            case 2:
            {
                var bitValue = ((rawValue >> 14) & 0x1);
                index = (int)bitValue;
                return true;
            }
            // MOV_umov_asimdins_x_x         : MOV         Xd, Vn.D[index] <- Operand: Vn.D[index]
            case 3:
            {
                var bitValue = ((rawValue >> 20) & 0x1);
                index = (int)bitValue;
                return true;
            }
            // LD1_asisdlso_d1_1d            : LD1         {Vt.D}[index], [Xn|SP] <- Operand: {Vt.D}[index]
            // LD1_asisdlsop_d1_i1d          : LD1         {Vt.D}[index], [Xn|SP], #8 <- Operand: {Vt.D}[index]
            // LD1_asisdlsop_dx1_r1d         : LD1         {Vt.D}[index], [Xn|SP], Xm <- Operand: {Vt.D}[index]
            // LD2_asisdlso_d2_2d            : LD2         {Vt.D, Vt2.D}[index], [Xn|SP] <- Operand: {Vt.D, Vt2.D}[index]
            // LD2_asisdlsop_d2_i2d          : LD2         {Vt.D, Vt2.D}[index], [Xn|SP], #16 <- Operand: {Vt.D, Vt2.D}[index]
            // LD2_asisdlsop_dx2_r2d         : LD2         {Vt.D, Vt2.D}[index], [Xn|SP], Xm <- Operand: {Vt.D, Vt2.D}[index]
            // LD3_asisdlso_d3_3d            : LD3         {Vt.D, Vt2.D, Vt3.D}[index], [Xn|SP] <- Operand: {Vt.D, Vt2.D, Vt3.D}[index]
            // LD3_asisdlsop_d3_i3d          : LD3         {Vt.D, Vt2.D, Vt3.D}[index], [Xn|SP], #24 <- Operand: {Vt.D, Vt2.D, Vt3.D}[index]
            // LD3_asisdlsop_dx3_r3d         : LD3         {Vt.D, Vt2.D, Vt3.D}[index], [Xn|SP], Xm <- Operand: {Vt.D, Vt2.D, Vt3.D}[index]
            // LD4_asisdlso_d4_4d            : LD4         {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index], [Xn|SP] <- Operand: {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index]
            // LD4_asisdlsop_d4_i4d          : LD4         {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index], [Xn|SP], #32 <- Operand: {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index]
            // LD4_asisdlsop_dx4_r4d         : LD4         {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index], [Xn|SP], Xm <- Operand: {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index]
            // LDAP1_asisdlso_d1             : LDAP1       {Vt.D}[index], [Xn|SP] <- Operand: {Vt.D}[index]
            // ST1_asisdlso_d1_1d            : ST1         {Vt.D}[index], [Xn|SP] <- Operand: {Vt.D}[index]
            // ST1_asisdlsop_d1_i1d          : ST1         {Vt.D}[index], [Xn|SP], #8 <- Operand: {Vt.D}[index]
            // ST1_asisdlsop_dx1_r1d         : ST1         {Vt.D}[index], [Xn|SP], Xm <- Operand: {Vt.D}[index]
            // ST2_asisdlso_d2_2d            : ST2         {Vt.D, Vt2.D}[index], [Xn|SP] <- Operand: {Vt.D, Vt2.D}[index]
            // ST2_asisdlsop_d2_i2d          : ST2         {Vt.D, Vt2.D}[index], [Xn|SP], #16 <- Operand: {Vt.D, Vt2.D}[index]
            // ST2_asisdlsop_dx2_r2d         : ST2         {Vt.D, Vt2.D}[index], [Xn|SP], Xm <- Operand: {Vt.D, Vt2.D}[index]
            // ST3_asisdlso_d3_3d            : ST3         {Vt.D, Vt2.D, Vt3.D}[index], [Xn|SP] <- Operand: {Vt.D, Vt2.D, Vt3.D}[index]
            // ST3_asisdlsop_d3_i3d          : ST3         {Vt.D, Vt2.D, Vt3.D}[index], [Xn|SP], #24 <- Operand: {Vt.D, Vt2.D, Vt3.D}[index]
            // ST3_asisdlsop_dx3_r3d         : ST3         {Vt.D, Vt2.D, Vt3.D}[index], [Xn|SP], Xm <- Operand: {Vt.D, Vt2.D, Vt3.D}[index]
            // ST4_asisdlso_d4_4d            : ST4         {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index], [Xn|SP] <- Operand: {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index]
            // ST4_asisdlsop_d4_i4d          : ST4         {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index], [Xn|SP], #32 <- Operand: {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index]
            // ST4_asisdlsop_dx4_r4d         : ST4         {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index], [Xn|SP], Xm <- Operand: {Vt.D, Vt2.D, Vt3.D, Vt4.D}[index]
            // STL1_asisdlso_d1              : STL1        {Vt.D}[index], [Xn|SP] <- Operand: {Vt.D}[index]
            case 4:
            {
                var bitValue = ((rawValue >> 30) & 0x1);
                index = (int)bitValue;
                return true;
            }
            // BFDOT_asimdelem_e             : BFDOT       Vd.Ta, Vn.Tb, Vm.2H[index] <- Operand: Vm.2H[index]
            // FDOT_asimdelem_d              : FDOT        Vd.Ta, Vn.Tb, Vm.4B[index] <- Operand: Vm.4B[index]
            // SDOT_asimdelem_d              : SDOT        Vd.Ta, Vn.Tb, Vm.4B[index] <- Operand: Vm.4B[index]
            // SUDOT_asimdelem_d             : SUDOT       Vd.Ta, Vn.Tb, Vm.4B[index] <- Operand: Vm.4B[index]
            // UDOT_asimdelem_d              : UDOT        Vd.Ta, Vn.Tb, Vm.4B[index] <- Operand: Vm.4B[index]
            // USDOT_asimdelem_d             : USDOT       Vd.Ta, Vn.Tb, Vm.4B[index] <- Operand: Vm.4B[index]
            case 5:
            {
                var bitValue = ((rawValue >> 21) & 0x1) | ((rawValue >> 10) & 0x2);
                index = (int)bitValue;
                return true;
            }
            // SM3TT1A_vvv4_crypto3_imm2     : SM3TT1A     Vd.4S, Vn.4S, Vm.S[imm2] <- Operand: Vm.S[imm2]
            // SM3TT1B_vvv4_crypto3_imm2     : SM3TT1B     Vd.4S, Vn.4S, Vm.S[imm2] <- Operand: Vm.S[imm2]
            // SM3TT2A_vvv4_crypto3_imm2     : SM3TT2A     Vd.4S, Vn.4S, Vm.S[imm2] <- Operand: Vm.S[imm2]
            // SM3TT2B_vvv_crypto3_imm2      : SM3TT2B     Vd.4S, Vn.4S, Vm.S[imm2] <- Operand: Vm.S[imm2]
            case 6:
            {
                var bitValue = ((rawValue >> 12) & 0x3);
                index = (int)bitValue;
                return true;
            }
            // LUTI2_asimdtbl_l5             : LUTI2       Vd.16B, {Vn.16B}, Vm[index] <- Operand: Vm[index]
            // LUTI4_asimdtbl_l7             : LUTI4       Vd.8H, {Vn1.8H, Vn2.8H}, Vm[index] <- Operand: Vm[index]
            case 7:
            {
                var bitValue = ((rawValue >> 13) & 0x3);
                index = (int)bitValue;
                return true;
            }
            // MOV_umov_asimdins_w_w         : MOV         Wd, Vn.S[index] <- Operand: Vn.S[index]
            case 8:
            {
                var bitValue = ((rawValue >> 19) & 0x3);
                index = (int)bitValue;
                return true;
            }
            // LD1_asisdlso_s1_1s            : LD1         {Vt.S}[index], [Xn|SP] <- Operand: {Vt.S}[index]
            // LD1_asisdlsop_s1_i1s          : LD1         {Vt.S}[index], [Xn|SP], #4 <- Operand: {Vt.S}[index]
            // LD1_asisdlsop_sx1_r1s         : LD1         {Vt.S}[index], [Xn|SP], Xm <- Operand: {Vt.S}[index]
            // LD2_asisdlso_s2_2s            : LD2         {Vt.S, Vt2.S}[index], [Xn|SP] <- Operand: {Vt.S, Vt2.S}[index]
            // LD2_asisdlsop_s2_i2s          : LD2         {Vt.S, Vt2.S}[index], [Xn|SP], #8 <- Operand: {Vt.S, Vt2.S}[index]
            // LD2_asisdlsop_sx2_r2s         : LD2         {Vt.S, Vt2.S}[index], [Xn|SP], Xm <- Operand: {Vt.S, Vt2.S}[index]
            // LD3_asisdlso_s3_3s            : LD3         {Vt.S, Vt2.S, Vt3.S}[index], [Xn|SP] <- Operand: {Vt.S, Vt2.S, Vt3.S}[index]
            // LD3_asisdlsop_s3_i3s          : LD3         {Vt.S, Vt2.S, Vt3.S}[index], [Xn|SP], #12 <- Operand: {Vt.S, Vt2.S, Vt3.S}[index]
            // LD3_asisdlsop_sx3_r3s         : LD3         {Vt.S, Vt2.S, Vt3.S}[index], [Xn|SP], Xm <- Operand: {Vt.S, Vt2.S, Vt3.S}[index]
            // LD4_asisdlso_s4_4s            : LD4         {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index], [Xn|SP] <- Operand: {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index]
            // LD4_asisdlsop_s4_i4s          : LD4         {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index], [Xn|SP], #16 <- Operand: {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index]
            // LD4_asisdlsop_sx4_r4s         : LD4         {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index], [Xn|SP], Xm <- Operand: {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index]
            // ST1_asisdlso_s1_1s            : ST1         {Vt.S}[index], [Xn|SP] <- Operand: {Vt.S}[index]
            // ST1_asisdlsop_s1_i1s          : ST1         {Vt.S}[index], [Xn|SP], #4 <- Operand: {Vt.S}[index]
            // ST1_asisdlsop_sx1_r1s         : ST1         {Vt.S}[index], [Xn|SP], Xm <- Operand: {Vt.S}[index]
            // ST2_asisdlso_s2_2s            : ST2         {Vt.S, Vt2.S}[index], [Xn|SP] <- Operand: {Vt.S, Vt2.S}[index]
            // ST2_asisdlsop_s2_i2s          : ST2         {Vt.S, Vt2.S}[index], [Xn|SP], #8 <- Operand: {Vt.S, Vt2.S}[index]
            // ST2_asisdlsop_sx2_r2s         : ST2         {Vt.S, Vt2.S}[index], [Xn|SP], Xm <- Operand: {Vt.S, Vt2.S}[index]
            // ST3_asisdlso_s3_3s            : ST3         {Vt.S, Vt2.S, Vt3.S}[index], [Xn|SP] <- Operand: {Vt.S, Vt2.S, Vt3.S}[index]
            // ST3_asisdlsop_s3_i3s          : ST3         {Vt.S, Vt2.S, Vt3.S}[index], [Xn|SP], #12 <- Operand: {Vt.S, Vt2.S, Vt3.S}[index]
            // ST3_asisdlsop_sx3_r3s         : ST3         {Vt.S, Vt2.S, Vt3.S}[index], [Xn|SP], Xm <- Operand: {Vt.S, Vt2.S, Vt3.S}[index]
            // ST4_asisdlso_s4_4s            : ST4         {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index], [Xn|SP] <- Operand: {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index]
            // ST4_asisdlsop_s4_i4s          : ST4         {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index], [Xn|SP], #16 <- Operand: {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index]
            // ST4_asisdlsop_sx4_r4s         : ST4         {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index], [Xn|SP], Xm <- Operand: {Vt.S, Vt2.S, Vt3.S, Vt4.S}[index]
            case 9:
            {
                var bitValue = ((rawValue >> 12) & 0x1) | ((rawValue >> 29) & 0x2);
                index = (int)bitValue;
                return true;
            }
            // BFMLALB_asimdelem_f           : BFMLALB     Vd.4S, Vn.8H, Vm.H[index] <- Operand: Vm.H[index]
            // BFMLALT_asimdelem_f           : BFMLALT     Vd.4S, Vn.8H, Vm.H[index] <- Operand: Vm.H[index]
            // FDOT_asimdelem_g              : FDOT        Vd.Ta, Vn.Tb, Vm.2B[index] <- Operand: Vm.2B[index]
            // FMLA_asimdelem_rh_h           : FMLA        Vd.T, Vn.T, Vm.H[index] <- Operand: Vm.H[index]
            // FMLA_asisdelem_rh_h           : FMLA        Hd, Hn, Vm.H[index] <- Operand: Vm.H[index]
            // FMLAL_asimdelem_lh            : FMLAL       Vd.Ta, Vn.Tb, Vm.H[index] <- Operand: Vm.H[index]
            // FMLAL2_asimdelem_lh           : FMLAL2      Vd.Ta, Vn.Tb, Vm.H[index] <- Operand: Vm.H[index]
            // FMLS_asimdelem_rh_h           : FMLS        Vd.T, Vn.T, Vm.H[index] <- Operand: Vm.H[index]
            // FMLS_asisdelem_rh_h           : FMLS        Hd, Hn, Vm.H[index] <- Operand: Vm.H[index]
            // FMLSL_asimdelem_lh            : FMLSL       Vd.Ta, Vn.Tb, Vm.H[index] <- Operand: Vm.H[index]
            // FMLSL2_asimdelem_lh           : FMLSL2      Vd.Ta, Vn.Tb, Vm.H[index] <- Operand: Vm.H[index]
            // FMUL_asimdelem_rh_h           : FMUL        Vd.T, Vn.T, Vm.H[index] <- Operand: Vm.H[index]
            // FMUL_asisdelem_rh_h           : FMUL        Hd, Hn, Vm.H[index] <- Operand: Vm.H[index]
            // FMULX_asimdelem_rh_h          : FMULX       Vd.T, Vn.T, Vm.H[index] <- Operand: Vm.H[index]
            // FMULX_asisdelem_rh_h          : FMULX       Hd, Hn, Vm.H[index] <- Operand: Vm.H[index]
            case 10:
            {
                var bitValue = ((rawValue >> 20) & 0x3) | ((rawValue >> 9) & 0x4);
                index = (int)bitValue;
                return true;
            }
            // LUTI2_asimdtbl_l6             : LUTI2       Vd.8H, {Vn.8H}, Vm[index] <- Operand: Vm[index]
            case 11:
            {
                var bitValue = ((rawValue >> 12) & 0x7);
                index = (int)bitValue;
                return true;
            }
            // FMLA_asimdelem_r_sd           : FMLA        Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMLA_asisdelem_r_sd           : FMLA        Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMLS_asimdelem_r_sd           : FMLS        Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMLS_asisdelem_r_sd           : FMLS        Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMUL_asimdelem_r_sd           : FMUL        Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMUL_asisdelem_r_sd           : FMUL        Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMULX_asimdelem_r_sd          : FMULX       Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // FMULX_asisdelem_r_sd          : FMULX       Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            case 12:
            {
                var bitValue = ((rawValue >> 11) & 0x1) | ((rawValue >> 20) & 0x6);
                var bitsToTest = ((bitValue >> 1) & 0x3);
                if (bitsToTest == 2)
                {
                    var extractedValue = (bitValue & 0x1);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x2) == 0)
                {
                    var extractedValue = ((bitValue >> 1) & 0x1) | ((bitValue << 1) & 0x2);
                    index = (int)extractedValue;
                    return true;
                }
                break;
            }
            // LD1_asisdlso_h1_1h            : LD1         {Vt.H}[index], [Xn|SP] <- Operand: {Vt.H}[index]
            // LD1_asisdlsop_h1_i1h          : LD1         {Vt.H}[index], [Xn|SP], #2 <- Operand: {Vt.H}[index]
            // LD1_asisdlsop_hx1_r1h         : LD1         {Vt.H}[index], [Xn|SP], Xm <- Operand: {Vt.H}[index]
            // LD2_asisdlso_h2_2h            : LD2         {Vt.H, Vt2.H}[index], [Xn|SP] <- Operand: {Vt.H, Vt2.H}[index]
            // LD2_asisdlsop_h2_i2h          : LD2         {Vt.H, Vt2.H}[index], [Xn|SP], #4 <- Operand: {Vt.H, Vt2.H}[index]
            // LD2_asisdlsop_hx2_r2h         : LD2         {Vt.H, Vt2.H}[index], [Xn|SP], Xm <- Operand: {Vt.H, Vt2.H}[index]
            // LD3_asisdlso_h3_3h            : LD3         {Vt.H, Vt2.H, Vt3.H}[index], [Xn|SP] <- Operand: {Vt.H, Vt2.H, Vt3.H}[index]
            // LD3_asisdlsop_h3_i3h          : LD3         {Vt.H, Vt2.H, Vt3.H}[index], [Xn|SP], #6 <- Operand: {Vt.H, Vt2.H, Vt3.H}[index]
            // LD3_asisdlsop_hx3_r3h         : LD3         {Vt.H, Vt2.H, Vt3.H}[index], [Xn|SP], Xm <- Operand: {Vt.H, Vt2.H, Vt3.H}[index]
            // LD4_asisdlso_h4_4h            : LD4         {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index], [Xn|SP] <- Operand: {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index]
            // LD4_asisdlsop_h4_i4h          : LD4         {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index], [Xn|SP], #8 <- Operand: {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index]
            // LD4_asisdlsop_hx4_r4h         : LD4         {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index], [Xn|SP], Xm <- Operand: {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index]
            // ST1_asisdlso_h1_1h            : ST1         {Vt.H}[index], [Xn|SP] <- Operand: {Vt.H}[index]
            // ST1_asisdlsop_h1_i1h          : ST1         {Vt.H}[index], [Xn|SP], #2 <- Operand: {Vt.H}[index]
            // ST1_asisdlsop_hx1_r1h         : ST1         {Vt.H}[index], [Xn|SP], Xm <- Operand: {Vt.H}[index]
            // ST2_asisdlso_h2_2h            : ST2         {Vt.H, Vt2.H}[index], [Xn|SP] <- Operand: {Vt.H, Vt2.H}[index]
            // ST2_asisdlsop_h2_i2h          : ST2         {Vt.H, Vt2.H}[index], [Xn|SP], #4 <- Operand: {Vt.H, Vt2.H}[index]
            // ST2_asisdlsop_hx2_r2h         : ST2         {Vt.H, Vt2.H}[index], [Xn|SP], Xm <- Operand: {Vt.H, Vt2.H}[index]
            // ST3_asisdlso_h3_3h            : ST3         {Vt.H, Vt2.H, Vt3.H}[index], [Xn|SP] <- Operand: {Vt.H, Vt2.H, Vt3.H}[index]
            // ST3_asisdlsop_h3_i3h          : ST3         {Vt.H, Vt2.H, Vt3.H}[index], [Xn|SP], #6 <- Operand: {Vt.H, Vt2.H, Vt3.H}[index]
            // ST3_asisdlsop_hx3_r3h         : ST3         {Vt.H, Vt2.H, Vt3.H}[index], [Xn|SP], Xm <- Operand: {Vt.H, Vt2.H, Vt3.H}[index]
            // ST4_asisdlso_h4_4h            : ST4         {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index], [Xn|SP] <- Operand: {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index]
            // ST4_asisdlsop_h4_i4h          : ST4         {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index], [Xn|SP], #8 <- Operand: {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index]
            // ST4_asisdlsop_hx4_r4h         : ST4         {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index], [Xn|SP], Xm <- Operand: {Vt.H, Vt2.H, Vt3.H, Vt4.H}[index]
            case 13:
            {
                var bitValue = ((rawValue >> 11) & 0x3) | ((rawValue >> 28) & 0x4);
                index = (int)bitValue;
                return true;
            }
            // FMLALB_asimdelem_h            : FMLALB      Vd.8H, Vn.16B, Vm.B[index] <- Operand: Vm.B[index]
            // FMLALLBB_asimdelem_j          : FMLALLBB    Vd.4S, Vn.16B, Vm.B[index] <- Operand: Vm.B[index]
            // FMLALLBT_asimdelem_j          : FMLALLBT    Vd.4S, Vn.16B, Vm.B[index] <- Operand: Vm.B[index]
            // FMLALLTB_asimdelem_j          : FMLALLTB    Vd.4S, Vn.16B, Vm.B[index] <- Operand: Vm.B[index]
            // FMLALLTT_asimdelem_j          : FMLALLTT    Vd.4S, Vn.16B, Vm.B[index] <- Operand: Vm.B[index]
            // FMLALT_asimdelem_h            : FMLALT      Vd.8H, Vn.16B, Vm.B[index] <- Operand: Vm.B[index]
            case 14:
            {
                var bitValue = ((rawValue >> 19) & 0x7) | ((rawValue >> 8) & 0x8);
                index = (int)bitValue;
                return true;
            }
            // FCMLA_advsimd_elt             : FCMLA       Vd.T, Vn.T, Vm.Ts[index], #rotate <- Operand: Vm.Ts[index]
            case 15:
            {
                var bitValue = ((rawValue >> 21) & 0x1) | ((rawValue >> 10) & 0x2) | ((rawValue >> 20) & 0xC);
                var bitsToTest = ((bitValue >> 2) & 0x3);
                switch (bitsToTest)
                {
                    case 1:
                    {
                        var extractedValue = (bitValue & 0x3);
                        index = (int)extractedValue;
                        return true;
                    }
                    case 2:
                    {
                        var extractedValue = ((bitValue >> 1) & 0x1);
                        index = (int)extractedValue;
                        return true;
                    }
                }
                break;
            }
            // LD1_asisdlso_b1_1b            : LD1         {Vt.B}[index], [Xn|SP] <- Operand: {Vt.B}[index]
            // LD1_asisdlsop_b1_i1b          : LD1         {Vt.B}[index], [Xn|SP], #1 <- Operand: {Vt.B}[index]
            // LD1_asisdlsop_bx1_r1b         : LD1         {Vt.B}[index], [Xn|SP], Xm <- Operand: {Vt.B}[index]
            // LD2_asisdlso_b2_2b            : LD2         {Vt.B, Vt2.B}[index], [Xn|SP] <- Operand: {Vt.B, Vt2.B}[index]
            // LD2_asisdlsop_b2_i2b          : LD2         {Vt.B, Vt2.B}[index], [Xn|SP], #2 <- Operand: {Vt.B, Vt2.B}[index]
            // LD2_asisdlsop_bx2_r2b         : LD2         {Vt.B, Vt2.B}[index], [Xn|SP], Xm <- Operand: {Vt.B, Vt2.B}[index]
            // LD3_asisdlso_b3_3b            : LD3         {Vt.B, Vt2.B, Vt3.B}[index], [Xn|SP] <- Operand: {Vt.B, Vt2.B, Vt3.B}[index]
            // LD3_asisdlsop_b3_i3b          : LD3         {Vt.B, Vt2.B, Vt3.B}[index], [Xn|SP], #3 <- Operand: {Vt.B, Vt2.B, Vt3.B}[index]
            // LD3_asisdlsop_bx3_r3b         : LD3         {Vt.B, Vt2.B, Vt3.B}[index], [Xn|SP], Xm <- Operand: {Vt.B, Vt2.B, Vt3.B}[index]
            // LD4_asisdlso_b4_4b            : LD4         {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index], [Xn|SP] <- Operand: {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index]
            // LD4_asisdlsop_b4_i4b          : LD4         {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index], [Xn|SP], #4 <- Operand: {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index]
            // LD4_asisdlsop_bx4_r4b         : LD4         {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index], [Xn|SP], Xm <- Operand: {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index]
            // ST1_asisdlso_b1_1b            : ST1         {Vt.B}[index], [Xn|SP] <- Operand: {Vt.B}[index]
            // ST1_asisdlsop_b1_i1b          : ST1         {Vt.B}[index], [Xn|SP], #1 <- Operand: {Vt.B}[index]
            // ST1_asisdlsop_bx1_r1b         : ST1         {Vt.B}[index], [Xn|SP], Xm <- Operand: {Vt.B}[index]
            // ST2_asisdlso_b2_2b            : ST2         {Vt.B, Vt2.B}[index], [Xn|SP] <- Operand: {Vt.B, Vt2.B}[index]
            // ST2_asisdlsop_b2_i2b          : ST2         {Vt.B, Vt2.B}[index], [Xn|SP], #2 <- Operand: {Vt.B, Vt2.B}[index]
            // ST2_asisdlsop_bx2_r2b         : ST2         {Vt.B, Vt2.B}[index], [Xn|SP], Xm <- Operand: {Vt.B, Vt2.B}[index]
            // ST3_asisdlso_b3_3b            : ST3         {Vt.B, Vt2.B, Vt3.B}[index], [Xn|SP] <- Operand: {Vt.B, Vt2.B, Vt3.B}[index]
            // ST3_asisdlsop_b3_i3b          : ST3         {Vt.B, Vt2.B, Vt3.B}[index], [Xn|SP], #3 <- Operand: {Vt.B, Vt2.B, Vt3.B}[index]
            // ST3_asisdlsop_bx3_r3b         : ST3         {Vt.B, Vt2.B, Vt3.B}[index], [Xn|SP], Xm <- Operand: {Vt.B, Vt2.B, Vt3.B}[index]
            // ST4_asisdlso_b4_4b            : ST4         {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index], [Xn|SP] <- Operand: {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index]
            // ST4_asisdlsop_b4_i4b          : ST4         {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index], [Xn|SP], #4 <- Operand: {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index]
            // ST4_asisdlsop_bx4_r4b         : ST4         {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index], [Xn|SP], Xm <- Operand: {Vt.B, Vt2.B, Vt3.B, Vt4.B}[index]
            case 16:
            {
                var bitValue = ((rawValue >> 10) & 0x7) | ((rawValue >> 27) & 0x8);
                index = (int)bitValue;
                return true;
            }
            // UMOV_asimdins_x_x             : UMOV        Xd, Vn.D[index] <- Operand: Vn.D[index]
            case 17:
            {
                var bitValue = ((rawValue >> 16) & 0x1F);
                index = (int)bitValue;
                return true;
            }
            // DUP_asimdins_dv_v             : DUP         Vd.T, Vn.Ts[index] <- Operand: Vn.Ts[index]
            // DUP_asisdone_only             : DUP         Vd, Vn.T[index] <- Operand: Vn.T[index]
            // INS_asimdins_ir_r             : INS         Vd.Ts[index], Rn <- Operand: Vd.Ts[index]
            // INS_asimdins_iv_v             : INS         Vd.Ts[index1], Vn.Ts[index2] <- Operand: Vd.Ts[index1]
            // MOV_dup_asisdone_only         : MOV         Vd, Vn.T[index] <- Operand: Vn.T[index]
            // MOV_ins_asimdins_ir_r         : MOV         Vd.Ts[index], Rn <- Operand: Vd.Ts[index]
            // MOV_ins_asimdins_iv_v         : MOV         Vd.Ts[index1], Vn.Ts[index2] <- Operand: Vd.Ts[index1]
            case 18:
            {
                var bitValue = ((rawValue >> 16) & 0x1F);
                var bitsToTest = (bitValue & 0x1F);
                if ((bitsToTest & 0xf) == 8)
                {
                    var extractedValue = ((bitValue >> 4) & 0x1);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x7) == 4)
                {
                    var extractedValue = ((bitValue >> 3) & 0x3);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x3) == 2)
                {
                    var extractedValue = ((bitValue >> 2) & 0x7);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x1) == 1)
                {
                    var extractedValue = ((bitValue >> 1) & 0xF);
                    index = (int)extractedValue;
                    return true;
                }
                break;
            }
            // SMOV_asimdins_x_x             : SMOV        Xd, Vn.Ts[index] <- Operand: Vn.Ts[index]
            // UMOV_asimdins_w_w             : UMOV        Wd, Vn.Ts[index] <- Operand: Vn.Ts[index]
            case 19:
            {
                var bitValue = ((rawValue >> 16) & 0x1F);
                var bitsToTest = (bitValue & 0x1F);
                if ((bitsToTest & 0x7) == 4)
                {
                    var extractedValue = ((bitValue >> 3) & 0x3);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x3) == 2)
                {
                    var extractedValue = ((bitValue >> 2) & 0x7);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x1) == 1)
                {
                    var extractedValue = ((bitValue >> 1) & 0xF);
                    index = (int)extractedValue;
                    return true;
                }
                break;
            }
            // SMOV_asimdins_w_w             : SMOV        Wd, Vn.Ts[index] <- Operand: Vn.Ts[index]
            case 20:
            {
                var bitValue = ((rawValue >> 16) & 0x1F);
                var bitsToTest = (bitValue & 0x1F);
                if ((bitsToTest & 0x3) == 2)
                {
                    var extractedValue = ((bitValue >> 2) & 0x7);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x1) == 1)
                {
                    var extractedValue = ((bitValue >> 1) & 0xF);
                    index = (int)extractedValue;
                    return true;
                }
                break;
            }
            // MLA_asimdelem_r               : MLA         Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // MLS_asimdelem_r               : MLS         Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // MUL_asimdelem_r               : MUL         Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SMLAL_asimdelem_l             : SMLAL       Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SMLAL2_asimdelem_l            : SMLAL2      Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SMLSL_asimdelem_l             : SMLSL       Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SMLSL2_asimdelem_l            : SMLSL2      Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SMULL_asimdelem_l             : SMULL       Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SMULL2_asimdelem_l            : SMULL2      Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMLAL_asimdelem_l           : SQDMLAL     Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMLAL_asisdelem_l           : SQDMLAL     Vad, Vbn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMLAL2_asimdelem_l          : SQDMLAL2    Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMLSL_asimdelem_l           : SQDMLSL     Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMLSL_asisdelem_l           : SQDMLSL     Vad, Vbn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMLSL2_asimdelem_l          : SQDMLSL2    Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMULH_asimdelem_r           : SQDMULH     Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMULH_asisdelem_r           : SQDMULH     Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMULL_asimdelem_l           : SQDMULL     Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMULL_asisdelem_l           : SQDMULL     Vad, Vbn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQDMULL2_asimdelem_l          : SQDMULL2    Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQRDMLAH_asimdelem_r          : SQRDMLAH    Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQRDMLAH_asisdelem_r          : SQRDMLAH    Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQRDMLSH_asimdelem_r          : SQRDMLSH    Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQRDMLSH_asisdelem_r          : SQRDMLSH    Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQRDMULH_asimdelem_r          : SQRDMULH    Vd.T, Vn.T, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // SQRDMULH_asisdelem_r          : SQRDMULH    Vd, Vn, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // UMLAL_asimdelem_l             : UMLAL       Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // UMLAL2_asimdelem_l            : UMLAL2      Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // UMLSL_asimdelem_l             : UMLSL       Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // UMLSL2_asimdelem_l            : UMLSL2      Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // UMULL_asimdelem_l             : UMULL       Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            // UMULL2_asimdelem_l            : UMULL2      Vd.Ta, Vn.Tb, Vm.Ts[index] <- Operand: Vm.Ts[index]
            case 21:
            {
                var bitValue = ((rawValue >> 20) & 0x3) | ((rawValue >> 9) & 0x4) | ((rawValue >> 19) & 0x18);
                var bitsToTest = ((bitValue >> 3) & 0x3);
                switch (bitsToTest)
                {
                    case 1:
                    {
                        var extractedValue = (bitValue & 0x7);
                        index = (int)extractedValue;
                        return true;
                    }
                    case 2:
                    {
                        var extractedValue = ((bitValue >> 1) & 0x3);
                        index = (int)extractedValue;
                        return true;
                    }
                }
                break;
            }
            // INS_asimdins_iv_v             : INS         Vd.Ts[index1], Vn.Ts[index2] <- Operand: Vn.Ts[index2]
            // MOV_ins_asimdins_iv_v         : MOV         Vd.Ts[index1], Vn.Ts[index2] <- Operand: Vn.Ts[index2]
            case 22:
            {
                var bitValue = ((rawValue >> 11) & 0xF) | ((rawValue >> 12) & 0x1F0);
                var bitsToTest = ((bitValue >> 4) & 0x1F);
                if ((bitsToTest & 0xf) == 8)
                {
                    var extractedValue = ((bitValue >> 3) & 0x1);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x7) == 4)
                {
                    var extractedValue = ((bitValue >> 2) & 0x3);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x3) == 2)
                {
                    var extractedValue = ((bitValue >> 1) & 0x7);
                    index = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x1) == 1)
                {
                    var extractedValue = (bitValue & 0xF);
                    index = (int)extractedValue;
                    return true;
                }
                break;
            }
        }
        
        index = default;
        return false;
    }
}
