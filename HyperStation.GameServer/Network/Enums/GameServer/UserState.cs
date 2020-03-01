using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum UserState
    {
        OFFLINE,
        ONLINE,
        AWAY,
        MATCH_QUEUE,
        CHANNEL,
        HYPER_SELECT,
        PLAYING,
        RECONNECT,
        RESTRICT_NAME,
        OBSERVING,
        GAME_END = 101,
        CHANNEL_WAIT,
        START_WAIT,
        QUEUE_WAIT,
        CHANGE_NAME
    }
}
