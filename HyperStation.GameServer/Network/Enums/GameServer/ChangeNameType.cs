using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ChangeNameType
    {
        CHANGE_BY_CHEAT,
        CHANGE_BY_CASH,
        CHANGE_BY_GAMEPOINT,
        CHANGE_BY_RESTRICT = 10
    }
}
