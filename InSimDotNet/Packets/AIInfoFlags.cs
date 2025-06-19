using System;

namespace InSimDotNet.Packets
{
    [Flags]
    public enum AIInfoFlags
    {
        AIFLAGS_IGNITION = 0x1,
        AIFLAGS_CHUP = 0x4,
        AIFLAGS_CHDN = 0x8
    }
}
