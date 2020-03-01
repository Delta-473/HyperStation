using System;

namespace HyperStation.GameServer.Network.Packet.Chat
{
    public enum PacketId
    {
        PING,
        CS_CONNECT,
        SC_CONNECT,
        CS_ENTER_CHAT,
        SC_ENTER_CHAT,
        SC_LEAVE_CHAT = 6,
        SC_ENTER_USER,
        SC_LEAVE_USER,
        CS_SEND_CHAT,
        SC_SEND_CHAT,
        SC_RECV_CHAT,
        SC_CHANGE_USER_LIST
    }
}
