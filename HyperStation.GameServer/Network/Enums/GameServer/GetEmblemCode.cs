using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum GetEmblemCode
    {
        GEC_DEFAULT,
        GEC_ACHIEVEMENT_REWARD,
        GEC_LEVEL_UP_REWARD,
        GEC_SHOP_BUY,
        GEC_PRESENT,
        GEC_GMTOOL_GIVE = 6,
        GEC_STORY_REWARD,
        GEC_PCBANG_TIME_GIFT_SEASON,
        GEC_LABORATORY_PRODUCT,
        GEC_PCBANG_TIME_GIFT_DAILY,
        GEC_ATTENDANCE_REWARD
    }
}
