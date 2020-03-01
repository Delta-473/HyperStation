using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum GMToolRestrictType
    {
        GMToolRestrictType_LoginBlock = 1,
        GMToolRestrictType_BattleRewardBlock,
        GMToolRestrictType_ChattingBlock,
        GMToolRestrictType_MatchingBlock,
        GMToolRestrictType_SystemLoginBlock
    }
}
