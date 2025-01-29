// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public enum Arm64CodeSyncKind : byte
{
    CSYNC = 0,
    Undefined = 0xFF,
}

public enum Arm64DataSyncKind : byte
{
    DSYNC = 0, 
    Undefined = 0xFF,
}

public enum Arm64RestrictionByContextKind : byte
{
    RCTX = 0,
    Undefined = 0xFF,
}