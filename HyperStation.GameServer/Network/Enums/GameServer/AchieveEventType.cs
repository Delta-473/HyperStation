using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum AchieveEventType
    {
        onGameResult = 1,
        onLevelUp,
        onHyperLevelUp,
        onStoryClear,
        onLobbyEnter
    }
}
