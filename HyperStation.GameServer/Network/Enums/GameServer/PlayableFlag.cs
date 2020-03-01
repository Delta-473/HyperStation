using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum PlayableFlag
    {
        PF_USER_SELECTABLE = 1,
        PF_RANDOM_SELECTABLE,
        PF_AI_SELECTABLE = 4
    }
}
