using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum GameResultCode
    {
        RET_LOSE,
        RET_WIN,
        RET_ESCAPED,
        RET_ABNORMAL,
        RET_DODGE
    }
}
