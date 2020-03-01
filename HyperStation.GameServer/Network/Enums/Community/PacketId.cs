using System;

namespace HyperStation.GameServer.Network.Packet.Community
{
    public enum PacketId
    {
        SC_FRIEND_LIST = 3,
        SC_FRIEND_CHANGE_LIST = 11,
        CS_CHANGE_STATE,
        SC_CHANGE_STATE,
        CS_CHANGE_STATE_MSG,
        SC_CHANGE_STATE_MSG,
        CS_SET_ACCOUNT_IMAGE,
        SC_SET_ACCOUNT_IMAGE,
        SC_INVITE_USER_NAME_CHANGED,
        SC_BAN_USER_NAME_CHANGED,
        CS_ADD_FRIEND = 31,
        SC_ADD_FRIEND,
        SC_RECV_ADD_FRIEND,
        CS_APPLY_ADD_FRIEND,
        SC_APPLY_ADD_FRIEND,
        SC_RECV_APPLY_ADD_FRIEND,
        CS_DEL_FRIEND,
        SC_DEL_FRIEND,
        SC_RECV_DEL_FRIEND,
        CS_SET_FRIEND_STATE,
        SC_SET_FRIEND_STATE,
        CS_SET_GROUP,
        SC_SET_GROUP,
        CS_SET_BAN_USER,
        SC_SET_BAN_USER,
        CS_WHISPER = 61,
        SC_WHISPER,
        SC_RECV_WHISPER,
        CS_ENTER_GROUP_CHAT = 71,
        SC_ENTER_GROUP_CHAT,
        CS_LEAVE_GROUP_CHAT,
        SC_LEAVE_GROUP_CHAT,
        CS_INVITE_GROUP_CHAT,
        SC_INVITE_GROUP_CHAT,
        SC_RECV_INVITE_GROUP_CHAT
    }
}
