using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSimDotNet.Packets
{
    public class IS_AIC : IPacket, ISendable
    {
        private const int AIC_MAX_INPUTS = 20;
        public int Size { get; private set; }

        public PacketType Type { get; private set; }

        public byte ReqI { get; set; }

        public byte PLID { get; set; }

        public IList<AIInputVal> Inputs { get; private set; }
        
        public IS_AIC()
        {
            Size = 8;
            Type = PacketType.ISP_AIC;
            Inputs = new List<AIInputVal>(AIC_MAX_INPUTS);
        }

        public IS_AIC(IEnumerable<AIInputVal> inputs)
            : this()
        {
            Inputs = new List<AIInputVal>(inputs);
        }

        public byte[] GetBuffer()
        {
            if (Inputs.Count > AIC_MAX_INPUTS)
                throw new InvalidOperationException("IS_AIC too many inputs set");
            Size = 4 + (Inputs.Count * 4);
            PacketWriter writer = new(Size);
            writer.WriteSize(Size);
            writer.Write((byte)Type);
            writer.Write(ReqI);
            writer.Write(PLID);

            foreach (AIInputVal input in Inputs)
            {
                input.GetBuffer(writer);
            }

            return writer.GetBuffer();
        }
    }
}
