using System;

namespace HyperStation.GameServer.Network.Packet.GameRoom
{
    public enum PacketId
    {
        PING,
        CS_CONNECT,
        SC_CONNECT,
        SC_JOIN_GAME,
        SC_ALL_ACCEPT_GAME = 11,
        SC_CANCEL_ROOM,
        CS_APPLY_GAME,
        SC_APPLY_GAME,
        SC_RECV_APPLY_GAME,
        CS_SEND_CHAT = 21,
        SC_SEND_CHAT,
        SC_RECV_CHAT,
        CS_SELECT_HYPER = 31,
        SC_SELECT_HYPER,
        CS_SELECT_SKIN,
        SC_SELECT_SKIN,
        CS_READY,
        SC_READY,
        SC_ALL_USER_READY,
        CS_BAN_HYPER,
        SC_BAN_HYPER,
        CS_TRADE_HYPER,
        SC_TRADE_HYPER,
        SC_RECV_TRADE_HYPER,
        CS_APPLY_TRADE_HYPER,
        SC_APPLY_TRADE_HYPER,
        SC_NOTIFY_TRADE_HYPER,
        SC_NOTIFY_BANPICK_STEP,
        SC_START_WAIT = 61,
        SC_START_GAME,
        CS_LEAVE_BATTLE = 65,
        SC_LEAVE_BATTLE,
        SC_RECV_LEAVE_BATTLE,
        CS_LEAVE_GAME_ROOM,
        SC_LEAVE_GAME_ROOM,
        SC_RECV_LEAVE_GAME_ROOM,
        CS_EVALUATE_USER,
        SC_EVALUATE_USER,
        SC_NO_REPLY_WARNING = 81
    }
}
