using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum MaterialChangeCode
    {
        MCC_GET_CUBEOPEN = 1,
        MCC_GET_CUBEOPEN_BONUS,
        MCC_PRODUCT,
        MCC_DECOMPOSTION,
        MCC_COMPOUND,
        MCC_GMTOOL_GIVE,
        MCC_GMTOOL_REMOVE,
        MCC_ATTENDANCE_REWARD,
        MCC_SHOP_BUY,
        MCC_STORY_REWARD,
        MCC_ACHIEVE_REWARD
    }
}
