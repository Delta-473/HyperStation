using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperStation.GameServer.Network
{
    public interface IPacket
    {
        void Encode(OutPacket oPacket);

        void Decode(InPacket iPacket);
    }
}
