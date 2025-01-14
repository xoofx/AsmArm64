// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

static class TesterDecoderVectorArrangement
{
    public static bool TryDecode(Arm64RawInstruction rawValue, byte valueArrangementIndex, out Arm64RegisterVKind vKind, out int elementCount)
    {
        switch (valueArrangementIndex)
        {
            case 0:
                return TryDecodeMapping((rawValue >> 10) & 0x1F, 14, out vKind, out elementCount);
            default:
                elementCount = 0;
                vKind = Arm64RegisterVKind.Default;
                return false;
        }
    }
    
    private static bool TryDecodeMapping(uint bitValues, byte valueArrangementValuesIndex, out Arm64RegisterVKind vKind, out int elementCount)
    {
        switch (valueArrangementValuesIndex)
        {
            case 0:
                switch (bitValues)
                {
                    case 0:
                        vKind = Arm64RegisterVKind.D;
                        elementCount = 16;
                        return true;
                        break;
                }

                break;
        }
        elementCount = 0;
        vKind = Arm64RegisterVKind.Default;
        return false;
    }
}