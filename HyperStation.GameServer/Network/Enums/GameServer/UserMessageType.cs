using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum UserMessageType
    {
        UserMessageType_GMSetRestrict = 1,
        UserMessageType_GMSetItem,
        UserMessageType_GMDelItem,
        UserMessageType_RankReward
    }
}
