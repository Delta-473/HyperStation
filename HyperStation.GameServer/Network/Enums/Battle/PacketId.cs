using System;

namespace HyperStation.GameServer.Network.Packet.Battle
{
    public enum PacketId
    {
        PING,
        PB_CONNECT,
        BP_CONNECT,
        PB_BATTLE_PROCESS_ON,
        BP_BATTLE_PROCESS_ON,
        PB_BATTLE_SERVER_READY,
        BP_BATTLE_SERVER_READY,
        PB_GAME_START,
        BP_GAME_START,
        PB_GAME_END,
        BP_GAME_END,
        BP_BATTLE_PROCESS_END,
        PB_BATTLE_PROCESS_END,
        BP_CONNECT_INFO,
        PB_OBSERVE_PROCESS_END,
        PB_NO_REPLY_USER = 19,
        BP_NO_REPLY_USER,
        PB_CLOSE_SESSION,
        BP_CLOSE_SESSION,
        PB_BATTLE_LOG = 31,
        BP_BATTLE_LOG,
        PB_BATTLE_CHAT_LOG,
        BP_BATTLE_CHAT_LOG,
        PB_BATTLE_INFO,
        BP_BATTLE_INFO,
        PB_DISCONNECT_RELAY_SERVER = 51,
        BP_DISCONNECT_RELAY_SERVER,
        BP_UNLINK_OBSERVER_SERVER
    }
}
