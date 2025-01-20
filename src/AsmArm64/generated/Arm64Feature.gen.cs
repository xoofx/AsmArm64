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
public enum Arm64Feature : byte
{
    /// <summary>
    /// The feature is invalid / unknown.
    /// </summary>
    Invalid,
    /// <summary>
    /// Feature `AES`.
    /// </summary>
    AES,
    /// <summary>
    /// Feature `ASMv8p2`.
    /// </summary>
    ASMv8p2,
    /// <summary>
    /// Feature `AdvSIMD`.
    /// </summary>
    AdvSIMD,
    /// <summary>
    /// Feature `BF16`.
    /// </summary>
    BF16,
    /// <summary>
    /// Feature `BRBE`.
    /// </summary>
    BRBE,
    /// <summary>
    /// Feature `BTI`.
    /// </summary>
    BTI,
    /// <summary>
    /// Feature `CHK`.
    /// </summary>
    CHK,
    /// <summary>
    /// Feature `CLRBHB`.
    /// </summary>
    CLRBHB,
    /// <summary>
    /// Feature `CMPBR`.
    /// </summary>
    CMPBR,
    /// <summary>
    /// Feature `CPA`.
    /// </summary>
    CPA,
    /// <summary>
    /// Feature `CRC32`.
    /// </summary>
    CRC32,
    /// <summary>
    /// Feature `CSSC`.
    /// </summary>
    CSSC,
    /// <summary>
    /// Feature `D128`.
    /// </summary>
    D128,
    /// <summary>
    /// Feature `DGH`.
    /// </summary>
    DGH,
    /// <summary>
    /// Feature `DotProd`.
    /// </summary>
    DotProd,
    /// <summary>
    /// Feature `F8F16MM`.
    /// </summary>
    F8F16MM,
    /// <summary>
    /// Feature `F8F32MM`.
    /// </summary>
    F8F32MM,
    /// <summary>
    /// Feature `FAMINMAX`.
    /// </summary>
    FAMINMAX,
    /// <summary>
    /// Feature `FCMA`.
    /// </summary>
    FCMA,
    /// <summary>
    /// Feature `FHM`.
    /// </summary>
    FHM,
    /// <summary>
    /// Feature `FP`.
    /// </summary>
    FP,
    /// <summary>
    /// Feature `FP16`.
    /// </summary>
    FP16,
    /// <summary>
    /// Feature `FP8`.
    /// </summary>
    FP8,
    /// <summary>
    /// Feature `FP8DOT2`.
    /// </summary>
    FP8DOT2,
    /// <summary>
    /// Feature `FP8DOT4`.
    /// </summary>
    FP8DOT4,
    /// <summary>
    /// Feature `FP8FMA`.
    /// </summary>
    FP8FMA,
    /// <summary>
    /// Feature `FPRCVT`.
    /// </summary>
    FPRCVT,
    /// <summary>
    /// Feature `FRINTTS`.
    /// </summary>
    FRINTTS,
    /// <summary>
    /// Feature `FlagM`.
    /// </summary>
    FlagM,
    /// <summary>
    /// Feature `FlagM2`.
    /// </summary>
    FlagM2,
    /// <summary>
    /// Feature `GCS`.
    /// </summary>
    GCS,
    /// <summary>
    /// Feature `HBC`.
    /// </summary>
    HBC,
    /// <summary>
    /// Feature `I8MM`.
    /// </summary>
    I8MM,
    /// <summary>
    /// Feature `ITE`.
    /// </summary>
    ITE,
    /// <summary>
    /// Feature `JSCVT`.
    /// </summary>
    JSCVT,
    /// <summary>
    /// Feature `LOR`.
    /// </summary>
    LOR,
    /// <summary>
    /// Feature `LRCPC`.
    /// </summary>
    LRCPC,
    /// <summary>
    /// Feature `LRCPC2`.
    /// </summary>
    LRCPC2,
    /// <summary>
    /// Feature `LRCPC3`.
    /// </summary>
    LRCPC3,
    /// <summary>
    /// Feature `LS64`.
    /// </summary>
    LS64,
    /// <summary>
    /// Feature `LS64_ACCDATA`.
    /// </summary>
    LS64_ACCDATA,
    /// <summary>
    /// Feature `LS64_V`.
    /// </summary>
    LS64_V,
    /// <summary>
    /// Feature `LSE`.
    /// </summary>
    LSE,
    /// <summary>
    /// Feature `LSE128`.
    /// </summary>
    LSE128,
    /// <summary>
    /// Feature `LSFE`.
    /// </summary>
    LSFE,
    /// <summary>
    /// Feature `LSUI`.
    /// </summary>
    LSUI,
    /// <summary>
    /// Feature `LUT`.
    /// </summary>
    LUT,
    /// <summary>
    /// Feature `MOPS`.
    /// </summary>
    MOPS,
    /// <summary>
    /// Feature `MTE`.
    /// </summary>
    MTE,
    /// <summary>
    /// Feature `MTE2`.
    /// </summary>
    MTE2,
    /// <summary>
    /// Feature `PAuth`.
    /// </summary>
    PAuth,
    /// <summary>
    /// Feature `PAuth_LR`.
    /// </summary>
    PAuth_LR,
    /// <summary>
    /// Feature `PCDPHINT`.
    /// </summary>
    PCDPHINT,
    /// <summary>
    /// Feature `RAS`.
    /// </summary>
    RAS,
    /// <summary>
    /// Feature `RDM`.
    /// </summary>
    RDM,
    /// <summary>
    /// Feature `RME_GPC3`.
    /// </summary>
    RME_GPC3,
    /// <summary>
    /// Feature `RPRFM`.
    /// </summary>
    RPRFM,
    /// <summary>
    /// Feature `SB`.
    /// </summary>
    SB,
    /// <summary>
    /// Feature `SHA1`.
    /// </summary>
    SHA1,
    /// <summary>
    /// Feature `SHA256`.
    /// </summary>
    SHA256,
    /// <summary>
    /// Feature `SHA3`.
    /// </summary>
    SHA3,
    /// <summary>
    /// Feature `SHA512`.
    /// </summary>
    SHA512,
    /// <summary>
    /// Feature `SM3`.
    /// </summary>
    SM3,
    /// <summary>
    /// Feature `SM4`.
    /// </summary>
    SM4,
    /// <summary>
    /// Feature `SME`.
    /// </summary>
    SME,
    /// <summary>
    /// Feature `SPE`.
    /// </summary>
    SPE,
    /// <summary>
    /// Feature `SPECRES`.
    /// </summary>
    SPECRES,
    /// <summary>
    /// Feature `SPECRES2`.
    /// </summary>
    SPECRES2,
    /// <summary>
    /// Feature `SYSINSTR128`.
    /// </summary>
    SYSINSTR128,
    /// <summary>
    /// Feature `SYSREG128`.
    /// </summary>
    SYSREG128,
    /// <summary>
    /// Feature `THE`.
    /// </summary>
    THE,
    /// <summary>
    /// Feature `TME`.
    /// </summary>
    TME,
    /// <summary>
    /// Feature `TRF`.
    /// </summary>
    TRF,
    /// <summary>
    /// Feature `WFxT`.
    /// </summary>
    WFxT,
    /// <summary>
    /// Feature `XS`.
    /// </summary>
    XS,
}
