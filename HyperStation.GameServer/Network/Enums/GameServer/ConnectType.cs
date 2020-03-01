using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ConnectType
    {
        CT_NORMAL = 1,
        CT_RECONNECT,
        CT_OBSERVE = 10,
        CT_RELAY_SERVER
    }
}
