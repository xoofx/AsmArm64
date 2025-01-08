// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace AsmArm64.CodeGen.Model;

internal class BitFieldSet : List<BitKind>
{
    public override string ToString()
    {
        var builder = new StringBuilder();
        foreach (var fieldSet in this)
        {
            builder.Append(fieldSet switch
            {
                BitKind.Zero => "0",
                BitKind.One => "1",
                BitKind.NotSet => "x",
                _ => throw new ArgumentOutOfRangeException()
            });
        }

        return builder.ToString();
    }
}