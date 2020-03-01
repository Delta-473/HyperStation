using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum EndUserState
    {
        NONE,
        INGAME,
        ROOM,
        LEAVE,
        ESCAPE
    }
}
