using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ChatType
    {
        PublicChat = 1,
        WhisperChat,
        GroupChat,
        PartyChat,
        BattleRoom
    }
}
