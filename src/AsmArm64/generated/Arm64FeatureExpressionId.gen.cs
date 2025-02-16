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

/// <summary>
/// A list of ARM64 CPU features.
/// </summary>
public enum Arm64FeatureExpressionId : byte
{
    /// <summary>
    /// There is no specific CPU features.
    /// </summary>
    None,
    /// <summary>
    /// Feature `FEAT_AES` for `ARMv8.0`.
    /// </summary>
    AES = 1,
    /// <summary>
    /// Feature `FEAT_ASMv8p2` for `ARMv8.2`.
    /// </summary>
    ASMv8p2 = 2,
    /// <summary>
    /// Feature `FEAT_AdvSIMD` for `ARMv8.0`.
    /// </summary>
    AdvSIMD = 3,
    /// <summary>
    /// Feature `FEAT_AdvSIMD &amp;&amp; FEAT_FAMINMAX`.
    /// </summary>
    AdvSIMD_And_FAMINMAX = 4,
    /// <summary>
    /// Feature `FEAT_AdvSIMD &amp;&amp; FEAT_FP16`.
    /// </summary>
    AdvSIMD_And_FP16 = 5,
    /// <summary>
    /// Feature `FEAT_AdvSIMD &amp;&amp; FEAT_LRCPC3`.
    /// </summary>
    AdvSIMD_And_LRCPC3 = 6,
    /// <summary>
    /// Feature `FEAT_AdvSIMD &amp;&amp; FEAT_LUT`.
    /// </summary>
    AdvSIMD_And_LUT = 7,
    /// <summary>
    /// Feature `FEAT_BF16` for `ARMv8.6`.
    /// </summary>
    BF16 = 8,
    /// <summary>
    /// Feature `FEAT_BRBE` for `ARMv9.2`.
    /// </summary>
    BRBE = 9,
    /// <summary>
    /// Feature `FEAT_BTI` for `ARMv8.5`.
    /// </summary>
    BTI = 10,
    /// <summary>
    /// Feature `FEAT_CHK` for `ARMv9.4`.
    /// </summary>
    CHK = 11,
    /// <summary>
    /// Feature `FEAT_CLRBHB` for `ARMv8.9`.
    /// </summary>
    CLRBHB = 12,
    /// <summary>
    /// Feature `FEAT_CMPBR` for `ARMv9.6`.
    /// </summary>
    CMPBR = 13,
    /// <summary>
    /// Feature `FEAT_CPA` for `ARMv9.5`.
    /// </summary>
    CPA = 14,
    /// <summary>
    /// Feature `FEAT_CRC32` for `ARMv8.0`.
    /// </summary>
    CRC32 = 15,
    /// <summary>
    /// Feature `FEAT_CSSC` for `ARMv8.9`.
    /// </summary>
    CSSC = 16,
    /// <summary>
    /// Feature `FEAT_D128 &amp;&amp; FEAT_SYSINSTR128`.
    /// </summary>
    D128_And_SYSINSTR128 = 17,
    /// <summary>
    /// Feature `FEAT_D128 &amp;&amp; FEAT_THE`.
    /// </summary>
    D128_And_THE = 18,
    /// <summary>
    /// Feature `FEAT_DGH`.
    /// </summary>
    DGH = 19,
    /// <summary>
    /// Feature `FEAT_DotProd` for `ARMv8.4`.
    /// </summary>
    DotProd = 20,
    /// <summary>
    /// Feature `FEAT_F8F16MM` for `ARMv9.6`.
    /// </summary>
    F8F16MM = 21,
    /// <summary>
    /// Feature `FEAT_F8F32MM` for `ARMv9.6`.
    /// </summary>
    F8F32MM = 22,
    /// <summary>
    /// Feature `FEAT_FCMA` for `ARMv8.3`.
    /// </summary>
    FCMA = 23,
    /// <summary>
    /// Feature `FEAT_FHM` for `ARMv8.4`.
    /// </summary>
    FHM = 24,
    /// <summary>
    /// Feature `FEAT_FP` for `ARMv8.0`.
    /// </summary>
    FP = 25,
    /// <summary>
    /// Feature `FEAT_FP8` for `ARMv9.5`.
    /// </summary>
    FP8 = 26,
    /// <summary>
    /// Feature `FEAT_FP8DOT2` for `ARMv9.5`.
    /// </summary>
    FP8DOT2 = 27,
    /// <summary>
    /// Feature `FEAT_FP8DOT4` for `ARMv9.5`.
    /// </summary>
    FP8DOT4 = 28,
    /// <summary>
    /// Feature `FEAT_FP8FMA` for `ARMv9.5`.
    /// </summary>
    FP8FMA = 29,
    /// <summary>
    /// Feature `FEAT_FPRCVT` for `ARMv9.6`.
    /// </summary>
    FPRCVT = 30,
    /// <summary>
    /// Feature `FEAT_FP &amp;&amp; FEAT_LRCPC3`.
    /// </summary>
    FP_And_LRCPC3 = 31,
    /// <summary>
    /// Feature `FEAT_FP &amp;&amp; FEAT_LSUI`.
    /// </summary>
    FP_And_LSUI = 32,
    /// <summary>
    /// Feature `FEAT_FRINTTS` for `ARMv8.5`.
    /// </summary>
    FRINTTS = 33,
    /// <summary>
    /// Feature `FEAT_FlagM` for `ARMv8.4`.
    /// </summary>
    FlagM = 34,
    /// <summary>
    /// Feature `FEAT_FlagM2` for `ARMv8.5`.
    /// </summary>
    FlagM2 = 35,
    /// <summary>
    /// Feature `FEAT_GCS` for `ARMv9.4`.
    /// </summary>
    GCS = 36,
    /// <summary>
    /// Feature `FEAT_HBC` for `ARMv8.8`.
    /// </summary>
    HBC = 37,
    /// <summary>
    /// Feature `FEAT_I8MM`.
    /// </summary>
    I8MM = 38,
    /// <summary>
    /// Feature `FEAT_ITE` for `ARMv9.4`.
    /// </summary>
    ITE = 39,
    /// <summary>
    /// Feature `FEAT_JSCVT` for `ARMv8.3`.
    /// </summary>
    JSCVT = 40,
    /// <summary>
    /// Feature `FEAT_LOR`.
    /// </summary>
    LOR = 41,
    /// <summary>
    /// Feature `FEAT_LRCPC` for `ARMv8.3`.
    /// </summary>
    LRCPC = 42,
    /// <summary>
    /// Feature `FEAT_LRCPC2` for `ARMv8.4`.
    /// </summary>
    LRCPC2 = 43,
    /// <summary>
    /// Feature `FEAT_LRCPC3` for `ARMv8.9`.
    /// </summary>
    LRCPC3 = 44,
    /// <summary>
    /// Feature `FEAT_LS64` for `ARMv8.7`.
    /// </summary>
    LS64 = 45,
    /// <summary>
    /// Feature `FEAT_LS64_ACCDATA` for `ARMv8.7`.
    /// </summary>
    LS64_ACCDATA = 46,
    /// <summary>
    /// Feature `FEAT_LS64_V` for `ARMv8.7`.
    /// </summary>
    LS64_V = 47,
    /// <summary>
    /// Feature `FEAT_LSE` for `ARMv8.1`.
    /// </summary>
    LSE = 48,
    /// <summary>
    /// Feature `FEAT_LSE128` for `ARMv9.4`.
    /// </summary>
    LSE128 = 49,
    /// <summary>
    /// Feature `FEAT_LSFE` for `ARMv9.6`.
    /// </summary>
    LSFE = 50,
    /// <summary>
    /// Feature `FEAT_LSUI` for `ARMv9.6`.
    /// </summary>
    LSUI = 51,
    /// <summary>
    /// Feature `FEAT_MOPS` for `ARMv8.8`.
    /// </summary>
    MOPS = 52,
    /// <summary>
    /// Feature `FEAT_MTE` for `ARMv8.5`.
    /// </summary>
    MTE = 53,
    /// <summary>
    /// Feature `FEAT_MTE2` for `ARMv8.5`.
    /// </summary>
    MTE2 = 54,
    /// <summary>
    /// Feature `FEAT_PAuth` for `ARMv8.3`.
    /// </summary>
    PAuth = 55,
    /// <summary>
    /// Feature `FEAT_PAuth_LR` for `ARMv9.5`.
    /// </summary>
    PAuth_LR = 56,
    /// <summary>
    /// Feature `FEAT_PCDPHINT` for `ARMv9.6`.
    /// </summary>
    PCDPHINT = 57,
    /// <summary>
    /// Feature `FEAT_RAS` for `ARMv8.2`.
    /// </summary>
    RAS = 58,
    /// <summary>
    /// Feature `FEAT_RDM` for `ARMv8.1`.
    /// </summary>
    RDM = 59,
    /// <summary>
    /// Feature `FEAT_RME_GPC3` for `ARMv9.6`.
    /// </summary>
    RME_GPC3 = 60,
    /// <summary>
    /// Feature `FEAT_RPRFM` for `ARMv8.9`.
    /// </summary>
    RPRFM = 61,
    /// <summary>
    /// Feature `FEAT_SB`.
    /// </summary>
    SB = 62,
    /// <summary>
    /// Feature `FEAT_SHA1` for `ARMv8.0`.
    /// </summary>
    SHA1 = 63,
    /// <summary>
    /// Feature `FEAT_SHA256` for `ARMv8.0`.
    /// </summary>
    SHA256 = 64,
    /// <summary>
    /// Feature `FEAT_SHA3` for `ARMv8.2`.
    /// </summary>
    SHA3 = 65,
    /// <summary>
    /// Feature `FEAT_SHA512` for `ARMv8.2`.
    /// </summary>
    SHA512 = 66,
    /// <summary>
    /// Feature `FEAT_SM3` for `ARMv8.2`.
    /// </summary>
    SM3 = 67,
    /// <summary>
    /// Feature `FEAT_SM4` for `ARMv8.2`.
    /// </summary>
    SM4 = 68,
    /// <summary>
    /// Feature `FEAT_SME`.
    /// </summary>
    SME = 69,
    /// <summary>
    /// Feature `FEAT_SPE`.
    /// </summary>
    SPE = 70,
    /// <summary>
    /// Feature `FEAT_SPECRES`.
    /// </summary>
    SPECRES = 71,
    /// <summary>
    /// Feature `FEAT_SPECRES2` for `ARMv8.9`.
    /// </summary>
    SPECRES2 = 72,
    /// <summary>
    /// Feature `FEAT_SYSINSTR128` for `ARMv9.4`.
    /// </summary>
    SYSINSTR128 = 73,
    /// <summary>
    /// Feature `FEAT_SYSREG128` for `ARMv9.4`.
    /// </summary>
    SYSREG128 = 74,
    /// <summary>
    /// Feature `FEAT_THE` for `ARMv8.9`.
    /// </summary>
    THE = 75,
    /// <summary>
    /// Feature `FEAT_TME` for `ARMv9.0`.
    /// </summary>
    TME = 76,
    /// <summary>
    /// Feature `FEAT_TRF` for `ARMv8.4`.
    /// </summary>
    TRF = 77,
    /// <summary>
    /// Feature `FEAT_WFxT` for `ARMv8.7`.
    /// </summary>
    WFxT = 78,
    /// <summary>
    /// Feature `FEAT_XS` for `ARMv8.7`.
    /// </summary>
    XS = 79,
}
