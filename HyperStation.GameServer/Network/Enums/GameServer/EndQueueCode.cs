using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum EndQueueCode
    {
        EQC_MATCH_COMPLETE = 1,
        EQC_MATCH_CANCLE_SELF,
        EQC_MATCH_CANCLE_OTHER,
        EQC_MATCH_CANCLE_CLOSE_SESSION,
        EQC_MATCH_CHANGE_QUEUE = 9,
        EQC_MATCH_CANCEL_SYSTEM
    }
}
