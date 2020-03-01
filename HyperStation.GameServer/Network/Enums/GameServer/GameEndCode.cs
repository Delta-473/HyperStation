using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum GameEndCode
    {
        NORMAL,
        CRASH,
        HANG,
        KILL_PROCESS = 5,
        CANCEL_MATCH,
        ALL_LEAVE,
        CLOSE_SERVER,
        ABNORMAL,
        END_OBSERVE = 101
    }
}
