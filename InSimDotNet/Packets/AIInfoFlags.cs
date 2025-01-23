using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
