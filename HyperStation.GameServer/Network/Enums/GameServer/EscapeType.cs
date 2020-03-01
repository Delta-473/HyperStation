using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum EscapeType
    {
        ESCAPE_NONE,
        ESCAPE_BATTLE_END,
        ESCAPE_TIME_OVER,
        CANCEL_DAILY_LIMIT,
        CANCEL_STREAK_LIMIT,
        OVER_DODGE_LIMIT,
        NO_REPLY_LEVEL_1,
        NO_REPLY_LEVEL_2,
        POINT_RESET,
        REPORT_BY_OTHERS,
        REPORT_BY_GM,
        USE_CHEAT_KEY
    }
}
