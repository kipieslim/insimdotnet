using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSimDotNet.Packets
{
    public class OSMain
    {
        public Vector AngVel { get; private set; }
        public float Heading { get; private set; }

        public float Pitch { get; private set; }

        public float Roll { get; private set; }

        public Vector Accel { get; private set; }

        public Vector Vel { get; private set; }

        public Vec Pos { get; private set; }

        public OSMain() { }

        public OSMain(PacketReader reader)
        {
            if (reader == null) throw new ArgumentNullException("reader");

            AngVel = new Vector(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            Heading = reader.ReadSingle();
            Pitch = reader.ReadSingle();
            Roll = reader.ReadSingle();
            Accel = new Vector(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            Vel = new Vector(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            Pos = new Vec(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
        }
    }
}
