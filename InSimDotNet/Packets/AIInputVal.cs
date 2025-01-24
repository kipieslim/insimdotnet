using System;

namespace InSimDotNet.Packets
{
    public class AIInputVal
    {
        public AIControlInput Input { get; set; }

        public byte Time { get; set; }

        public ushort Value { get; set; }

        public void GetBuffer(PacketWriter writer)
        {
            if (writer == null)
                throw new ArgumentException("writer");

            writer.Write((byte)Input);
            writer.Write(Time);
            writer.Write(Value);
        }
    }
}
