using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ChangeBattlePointCode
    {
        CBP_DEFAULT,
        CBP_BATTLE_REWARD,
        CBP_ACHIEVEMENT_REWARD,
        CBP_GM_ISSUE,
        CBP_SHOP_BUY,
        CBP_LEVEL_UP_REWARD,
        CBP_BOOSTER,
        CBP_GMTOOL_GIVE,
        CBP_GMTOOL_REMOVE,
        CBP_SHOP_BUY_BONUS,
        CBP_SHOP_BUY_PRESENT,
        CBP_PCBANG_GIFT_SEASON,
        CBP_STORY_REWARD,
        CBP_LABORATORY_PRODUCT,
        CBP_LABORATORY_DECOMPOSITION,
        CBP_LABORATORY_COMPOUND,
        CBP_PCBANG_GIFT_DAILY,
        CBP_ATTENDANCE_REWARD
    }
}
