using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ChangeStateType
    {
        STATE = 1,
        STATE_MSG,
        GAME_INFO = 4,
        LEVEL = 8,
        ACCOUNT_IMAGE = 16,
        PARTY = 32,
        ACCOUNT_LEVEL = 64,
        RANK_POINT = 128,
        FULL = 255,
        NAME,
        CONNECT_STATE = 16384,
        DISCONNECT_STATE = 32768
    }
}
