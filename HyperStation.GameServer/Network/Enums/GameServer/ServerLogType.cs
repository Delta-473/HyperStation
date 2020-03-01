using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ServerLogType
    {
        SYSTEM_LOG = 1,
        ERROR_LOG,
        GAME_LOG,
        DELAY_LOG,
        NEXON_LOG,
        WARN_LOG,
        BILLING_LOG,
        AUTH_LOG,
        SECURE_LOG,
        LOG_MAX = 100
    }
}
