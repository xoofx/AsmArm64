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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Decode Immediate class.
/// </summary>
static class Arm64ImmediateHelper
{
    public static bool TryDecode(Arm64RawInstruction rawValue, byte mapIndex, out int imm)
    {
        switch (mapIndex)
        {
            // FCADD_asimdsame2_c            : FCADD       Vd.T, Vn.T, Vm.T, #rotate <- Operand: #rotate
            case 1:
            {
                var bitValue = ((rawValue >> 12) & 0x1);
                var bitsToTest = (bitValue & 0x1);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)90;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)270;
                        return true;
                    }
                }
                break;
            }
            // LD1_asisdlsep_i2_i2           : LD1         {Vt.T, Vt2.T}, [Xn|SP], imm <- Operand: imm
            // LD2_asisdlsep_i2_i            : LD2         {Vt.T, Vt2.T}, [Xn|SP], imm <- Operand: imm
            // ST1_asisdlsep_i2_i2           : ST1         {Vt.T, Vt2.T}, [Xn|SP], imm <- Operand: imm
            // ST2_asisdlsep_i2_i            : ST2         {Vt.T, Vt2.T}, [Xn|SP], imm <- Operand: imm
            case 2:
            {
                var bitValue = ((rawValue >> 30) & 0x1);
                var bitsToTest = (bitValue & 0x1);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)16;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)32;
                        return true;
                    }
                }
                break;
            }
            // LD1_asisdlsep_i3_i3           : LD1         {Vt.T, Vt2.T, Vt3.T}, [Xn|SP], imm <- Operand: imm
            // LD3_asisdlsep_i3_i            : LD3         {Vt.T, Vt2.T, Vt3.T}, [Xn|SP], imm <- Operand: imm
            // ST1_asisdlsep_i3_i3           : ST1         {Vt.T, Vt2.T, Vt3.T}, [Xn|SP], imm <- Operand: imm
            // ST3_asisdlsep_i3_i            : ST3         {Vt.T, Vt2.T, Vt3.T}, [Xn|SP], imm <- Operand: imm
            case 3:
            {
                var bitValue = ((rawValue >> 30) & 0x1);
                var bitsToTest = (bitValue & 0x1);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)24;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)48;
                        return true;
                    }
                }
                break;
            }
            // LD1_asisdlsep_i4_i4           : LD1         {Vt.T, Vt2.T, Vt3.T, Vt4.T}, [Xn|SP], imm <- Operand: imm
            // LD4_asisdlsep_i4_i            : LD4         {Vt.T, Vt2.T, Vt3.T, Vt4.T}, [Xn|SP], imm <- Operand: imm
            // ST1_asisdlsep_i4_i4           : ST1         {Vt.T, Vt2.T, Vt3.T, Vt4.T}, [Xn|SP], imm <- Operand: imm
            // ST4_asisdlsep_i4_i            : ST4         {Vt.T, Vt2.T, Vt3.T, Vt4.T}, [Xn|SP], imm <- Operand: imm
            case 4:
            {
                var bitValue = ((rawValue >> 30) & 0x1);
                var bitsToTest = (bitValue & 0x1);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)32;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)64;
                        return true;
                    }
                }
                break;
            }
            // LD1_asisdlsep_i1_i1           : LD1         {Vt.T}, [Xn|SP], imm <- Operand: imm
            // ST1_asisdlsep_i1_i1           : ST1         {Vt.T}, [Xn|SP], imm <- Operand: imm
            case 5:
            {
                var bitValue = ((rawValue >> 30) & 0x1);
                var bitsToTest = (bitValue & 0x1);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)8;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)16;
                        return true;
                    }
                }
                break;
            }
            // LD1R_asisdlsop_r1_i           : LD1R        {Vt.T}, [Xn|SP], imm <- Operand: imm
            case 6:
            {
                var bitValue = ((rawValue >> 10) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)1;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)2;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)4;
                        return true;
                    }
                    case 3:
                    {
                        imm = (int)8;
                        return true;
                    }
                }
                break;
            }
            // LD2R_asisdlsop_r2_i           : LD2R        {Vt.T, Vt2.T}, [Xn|SP], imm <- Operand: imm
            case 7:
            {
                var bitValue = ((rawValue >> 10) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)2;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)4;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)8;
                        return true;
                    }
                    case 3:
                    {
                        imm = (int)16;
                        return true;
                    }
                }
                break;
            }
            // LD3R_asisdlsop_r3_i           : LD3R        {Vt.T, Vt2.T, Vt3.T}, [Xn|SP], imm <- Operand: imm
            case 8:
            {
                var bitValue = ((rawValue >> 10) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)3;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)6;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)12;
                        return true;
                    }
                    case 3:
                    {
                        imm = (int)24;
                        return true;
                    }
                }
                break;
            }
            // LD4R_asisdlsop_r4_i           : LD4R        {Vt.T, Vt2.T, Vt3.T, Vt4.T}, [Xn|SP], imm <- Operand: imm
            case 9:
            {
                var bitValue = ((rawValue >> 10) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)4;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)8;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)16;
                        return true;
                    }
                    case 3:
                    {
                        imm = (int)32;
                        return true;
                    }
                }
                break;
            }
            // FCMLA_asimdsame2_c            : FCMLA       Vd.T, Vn.T, Vm.T, #rotate <- Operand: #rotate
            case 10:
            {
                var bitValue = ((rawValue >> 11) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)0;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)90;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)180;
                        return true;
                    }
                    case 3:
                    {
                        imm = (int)270;
                        return true;
                    }
                }
                break;
            }
            // FCMLA_advsimd_elt             : FCMLA       Vd.T, Vn.T, Vm.Ts[index], #rotate <- Operand: #rotate
            case 11:
            {
                var bitValue = ((rawValue >> 13) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)0;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)90;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)180;
                        return true;
                    }
                    case 3:
                    {
                        imm = (int)270;
                        return true;
                    }
                }
                break;
            }
            // SHLL_asimdmisc_s              : SHLL        Vd.Ta, Vn.Tb, #shift <- Operand: #shift
            // SHLL2_asimdmisc_s             : SHLL2       Vd.Ta, Vn.Tb, #shift <- Operand: #shift
            case 12:
            {
                var bitValue = ((rawValue >> 22) & 0x3);
                var bitsToTest = (bitValue & 0x3);
                switch (bitsToTest)
                {
                    case 0:
                    {
                        imm = (int)8;
                        return true;
                    }
                    case 1:
                    {
                        imm = (int)16;
                        return true;
                    }
                    case 2:
                    {
                        imm = (int)32;
                        return true;
                    }
                }
                break;
            }
            // EXT_asimdext_only             : EXT         Vd.T, Vn.T, Vm.T, #index <- Operand: #index
            case 13:
            {
                var bitValue = ((rawValue >> 11) & 0xF) | ((rawValue >> 26) & 0x10);
                var bitsToTest = ((bitValue >> 3) & 0x3);
                if (bitsToTest == 0)
                {
                    var extractedValue = (bitValue & 0x7);
                    imm = (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x2) == 2)
                {
                    var extractedValue = (bitValue & 0xF);
                    imm = (int)extractedValue;
                    return true;
                }
                break;
            }
            // SRI_asimdshf_r                : SRI         Vd.T, Vn.T, #shift <- Operand: #shift
            // SRSHR_asimdshf_r              : SRSHR       Vd.T, Vn.T, #shift <- Operand: #shift
            // SRSRA_asimdshf_r              : SRSRA       Vd.T, Vn.T, #shift <- Operand: #shift
            // SSHR_asimdshf_r               : SSHR        Vd.T, Vn.T, #shift <- Operand: #shift
            // SSRA_asimdshf_r               : SSRA        Vd.T, Vn.T, #shift <- Operand: #shift
            // URSHR_asimdshf_r              : URSHR       Vd.T, Vn.T, #shift <- Operand: #shift
            // URSRA_asimdshf_r              : URSRA       Vd.T, Vn.T, #shift <- Operand: #shift
            // USHR_asimdshf_r               : USHR        Vd.T, Vn.T, #shift <- Operand: #shift
            // USRA_asimdshf_r               : USRA        Vd.T, Vn.T, #shift <- Operand: #shift
            case 14:
            {
                var bitValue = ((rawValue >> 16) & 0x7F);
                var bitsToTest = ((bitValue >> 3) & 0xF);
                if (bitsToTest == 1)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 16 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0xe) == 2)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 32 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0xc) == 4)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 64 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x8) == 8)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 128 - (int)extractedValue;
                    return true;
                }
                break;
            }
            // RSHRN_asimdshf_n              : RSHRN       Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // RSHRN2_asimdshf_n             : RSHRN2      Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SHRN_asimdshf_n               : SHRN        Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SHRN2_asimdshf_n              : SHRN2       Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQRSHRN_asimdshf_n            : SQRSHRN     Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQRSHRN_asisdshf_n            : SQRSHRN     Vbd, Van, #shift <- Operand: #shift
            // SQRSHRN2_asimdshf_n           : SQRSHRN2    Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQRSHRUN_asimdshf_n           : SQRSHRUN    Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQRSHRUN_asisdshf_n           : SQRSHRUN    Vbd, Van, #shift <- Operand: #shift
            // SQRSHRUN2_asimdshf_n          : SQRSHRUN2   Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQSHRN_asimdshf_n             : SQSHRN      Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQSHRN_asisdshf_n             : SQSHRN      Vbd, Van, #shift <- Operand: #shift
            // SQSHRN2_asimdshf_n            : SQSHRN2     Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQSHRUN_asimdshf_n            : SQSHRUN     Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // SQSHRUN_asisdshf_n            : SQSHRUN     Vbd, Van, #shift <- Operand: #shift
            // SQSHRUN2_asimdshf_n           : SQSHRUN2    Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // UQRSHRN_asimdshf_n            : UQRSHRN     Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // UQRSHRN_asisdshf_n            : UQRSHRN     Vbd, Van, #shift <- Operand: #shift
            // UQRSHRN2_asimdshf_n           : UQRSHRN2    Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // UQSHRN_asimdshf_n             : UQSHRN      Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            // UQSHRN_asisdshf_n             : UQSHRN      Vbd, Van, #shift <- Operand: #shift
            // UQSHRN2_asimdshf_n            : UQSHRN2     Vd.Tb, Vn.Ta, #shift <- Operand: #shift
            case 15:
            {
                var bitValue = ((rawValue >> 16) & 0x7F);
                var bitsToTest = ((bitValue >> 3) & 0xF);
                if (bitsToTest == 1)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 16 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0xe) == 2)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 32 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0xc) == 4)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 64 - (int)extractedValue;
                    return true;
                }
                break;
            }
            // SHL_asimdshf_r                : SHL         Vd.T, Vn.T, #shift <- Operand: #shift
            // SLI_asimdshf_r                : SLI         Vd.T, Vn.T, #shift <- Operand: #shift
            // SQSHL_asimdshf_r              : SQSHL       Vd.T, Vn.T, #shift <- Operand: #shift
            // SQSHL_asisdshf_r              : SQSHL       Vd, Vn, #shift <- Operand: #shift
            // SQSHLU_asimdshf_r             : SQSHLU      Vd.T, Vn.T, #shift <- Operand: #shift
            // SQSHLU_asisdshf_r             : SQSHLU      Vd, Vn, #shift <- Operand: #shift
            // UQSHL_asimdshf_r              : UQSHL       Vd.T, Vn.T, #shift <- Operand: #shift
            // UQSHL_asisdshf_r              : UQSHL       Vd, Vn, #shift <- Operand: #shift
            case 16:
            {
                var bitValue = ((rawValue >> 16) & 0x7F);
                var bitsToTest = ((bitValue >> 3) & 0xF);
                if (bitsToTest == 1)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 8;
                    return true;
                }
                if ((bitsToTest & 0xe) == 2)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 16;
                    return true;
                }
                if ((bitsToTest & 0xc) == 4)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 32;
                    return true;
                }
                if ((bitsToTest & 0x8) == 8)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 64;
                    return true;
                }
                break;
            }
            // SSHLL_asimdshf_l              : SSHLL       Vd.Ta, Vn.Tb, #shift <- Operand: #shift
            // SSHLL2_asimdshf_l             : SSHLL2      Vd.Ta, Vn.Tb, #shift <- Operand: #shift
            // USHLL_asimdshf_l              : USHLL       Vd.Ta, Vn.Tb, #shift <- Operand: #shift
            // USHLL2_asimdshf_l             : USHLL2      Vd.Ta, Vn.Tb, #shift <- Operand: #shift
            case 17:
            {
                var bitValue = ((rawValue >> 16) & 0x7F);
                var bitsToTest = ((bitValue >> 3) & 0xF);
                if (bitsToTest == 1)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 8;
                    return true;
                }
                if ((bitsToTest & 0xe) == 2)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 16;
                    return true;
                }
                if ((bitsToTest & 0xc) == 4)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = (int)extractedValue - 32;
                    return true;
                }
                break;
            }
            // FCVTZS_asimdshf_c             : FCVTZS      Vd.T, Vn.T, #fbits <- Operand: #fbits
            // FCVTZS_asisdshf_c             : FCVTZS      Vd, Vn, #fbits <- Operand: #fbits
            // FCVTZU_asimdshf_c             : FCVTZU      Vd.T, Vn.T, #fbits <- Operand: #fbits
            // FCVTZU_asisdshf_c             : FCVTZU      Vd, Vn, #fbits <- Operand: #fbits
            // SCVTF_asimdshf_c              : SCVTF       Vd.T, Vn.T, #fbits <- Operand: #fbits
            // SCVTF_asisdshf_c              : SCVTF       Vd, Vn, #fbits <- Operand: #fbits
            // UCVTF_asimdshf_c              : UCVTF       Vd.T, Vn.T, #fbits <- Operand: #fbits
            // UCVTF_asisdshf_c              : UCVTF       Vd, Vn, #fbits <- Operand: #fbits
            case 18:
            {
                var bitValue = ((rawValue >> 16) & 0x7F);
                var bitsToTest = ((bitValue >> 3) & 0xF);
                if ((bitsToTest & 0xe) == 2)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 32 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0xc) == 4)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 64 - (int)extractedValue;
                    return true;
                }
                if ((bitsToTest & 0x8) == 8)
                {
                    var extractedValue = (bitValue & 0x7F);
                    imm = 128 - (int)extractedValue;
                    return true;
                }
                break;
            }
        }
        
        imm = default;
        return false;
    }
}
