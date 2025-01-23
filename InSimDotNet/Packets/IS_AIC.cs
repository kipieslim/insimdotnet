using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSimDotNet.Packets
{
    public class IS_AIC : IPacket, ISendable
    {
        public int Size { get; private set; }

        public PacketType Type { get; private set; }

        public byte ReqI { get; set; }

        byte PLID { get; set; }

        byte Input { get; set; }

        int Value { get; set; }

        public IS_AIC()
        {
            Size = 8;
            Type = PacketType.ISP_AIC;
        }

        public IS_AIC(byte[] buffer)
            : this()
        {
            PacketReader reader = new PacketReader(buffer);
            Size = reader.ReadSize();
            Type = (PacketType)reader.ReadByte();
            ReqI = reader.ReadByte();
            reader.Skip(1);
            PLID = reader.ReadByte();
            Input = reader.ReadByte();
            Value = (int)reader.ReadUInt16();
        }

        public byte[] GetBuffer()
        {
            PacketWriter writer = new(Size);
            writer.WriteSize(Size);
            writer.Write((byte)Type);
            writer.Write(ReqI);
            writer.Skip(1);
            writer.Write(PLID);
            writer.Write(Input);
            writer.Write((ushort)Value);
            return writer.GetBuffer();
        }
    }
}
