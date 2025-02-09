// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

enum BitRangeCondition
{
    None,
    Unknown,
    AllNonZero,
    AllNonOne,
    AllNon011,
    AllNon011111,
    AllNon111x,
    AllNon11xxx
}