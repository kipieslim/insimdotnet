using InSimDotNet.Out;

namespace InSimDotNet.Packets
{
    public class IS_AII : IPacket
    {
        public int Size { get; private set; }

        public PacketType Type { get; private set; }

        public byte ReqI { get; set; }

        public byte PLID { get; private set; }

        public OSMain OSData { get; private set; }

        public AIInfoFlags Flags { get; private set; }

        public byte Gear { get; private set; }

        public float RPM { get; private set; }

        public DashLightFlags ShowLights { get; private set; }

        public IS_AII()
        {
            Size = 96;
            Type = PacketType.ISP_AII;
        }

        public IS_AII(byte[] buffer)
        {
            PacketReader reader = new(buffer);
            Size = reader.ReadSize();
            Type = (PacketType)reader.ReadByte();
            ReqI = reader.ReadByte();
            PLID = reader.ReadByte();
            OSData = new OSMain(reader);
            Flags = (AIInfoFlags)reader.ReadByte();
            Gear = reader.ReadByte();
            reader.Skip(2);
            RPM = reader.ReadSingle();
            reader.Skip(8);
            ShowLights = (DashLightFlags)reader.ReadUInt32();
            reader.Skip(12);
        }
    }
}
