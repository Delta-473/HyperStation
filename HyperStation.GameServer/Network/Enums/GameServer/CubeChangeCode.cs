using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum CubeChangeCode
    {
        CCC_PCBANG_DAILY_GIFT = 1,
        CCC_GAME_RESULT,
        CCC_USE_CUBEOPEN,
        CCC_GM_TOOL_GIVE,
        CCC_GM_TOOL_REMOVE,
        CCC_PCBANG_SEASON_GIFT,
        CCC_SHOP_BUY,
        CCC_GIFT_FROM_USER,
        CCC_ATTENDANCE_REWARD,
        CCC_STORY_REWARD,
        CCC_ACHIEVE_REWARD
    }
}
