using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ChatSubType
    {
        BanPickMode = 1,
        InGameMode,
        GameResultMode,
        InviteChannelMode,
        CustomGameChannelMode,
        MatchGameChannelMode,
        PrivateChannelMode
    }
}
