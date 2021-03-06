﻿using System;

namespace HyperStation.GameServer.Network.Packet.Session
{
    public enum PacketId
    {
        PING,
        CS_GENERATE_KEY,
        SC_GENERATE_KEY,
        CS_CONNECT,
        SC_CONNECT,
        CS_CREATE_USER,
        SC_CREATE_USER,
        SC_ACCOUNT_LOGIN_BLOCK,
        SC_KICKOUT_NOTIFY_USER,
        SC_NOTICE_MESSAGE = 15,
        SC_ADD_CONTENTS_RESTRICT,
        SC_DEL_CONTENTS_RESTRICT,
        SC_ADD_EVENT_BUFF,
        SC_DEL_EVENT_BUFF,
        SC_ADD_USER_LOG_MESSAGE = 25,
        SC_ADDITEM_BY_GM,
        SC_DELITEM_BY_GM,
        SC_NO_MANNER_WARNING = 31,
        SC_GET_LIKE_POINT,
        CS_COMPLETE_TUTORIAL,
        SC_COMPLETE_TUTORIAL,
        CS_ESCAPE_TUTORIAL,
        SC_ESCAPE_TUTORIAL,
        CS_SKIP_TUTORIAL,
        SC_SKIP_TUTORIAL,
        CS_RECOMMEND_USER = 41,
        SC_RECOMMEND_USER,
        SC_RECOMMEND_USER_LEVEL_ACHIEVED,
        SC_ACHIEVED_LIST = 46,
        SC_ACHIEVED_PERIOD_LIST,
        SC_BATTLE_RECORDS = 51,
        CS_ACHIEVED_STORY,
        SC_ACHIEVED_STORY,
        CS_PCBANG_PLAYTIME_GIFT = 61,
        SC_PCBANG_PLAYTIME_GIFT,
        SC_PCBANG_PLAYTIME_SEASON_CHANGE,
        CS_SET_SHOW_NAME_BOX,
        SC_SET_SHOW_NAME_BOX,
        SC_RECONNECT_INFO = 71,
        CS_START_MATCH,
        SC_START_MATCH,
        CS_CANCEL_MATCH,
        SC_CANCEL_MATCH,
        SC_WAIT_START_GAME,
        SC_START_GAME,
        CS_RETURN_LOBBY,
        SC_RETURN_LOBBY,
        SC_CANCEL_ROOM,
        CS_START_SOLO_GAME,
        SC_START_SOLO_GAME,
        SC_BREAK_ROOM,
        CS_RECONNECT_GAME,
        SC_RECONNECT_GAME,
        CS_OBSERVE_GAME,
        SC_OBSERVE_GAME,
        SC_UPDATE_BATTLE_RECORD,
        CS_REPORT_NOMANNER_USER = 101,
        SC_REPORT_NOMANNER_USER,
        CS_CHEAT_COMMAND,
        SC_CHEAT_COMMAND,
        CS_ENTER_PUBLIC_CHAT,
        SC_ENTER_PUBLIC_CHAT,
        SC_PUBLIC_CHAT_ENTER_USER,
        CS_LEAVE_PUBLIC_CHAT,
        SC_LEAVE_PUBLIC_CHAT,
        SC_PUBLIC_CHAT_LEAVE_USER,
        CS_SEND_PUBLIC_CHAT,
        SC_SEND_PUBLIC_CHAT,
        SC_RECV_PUBLIC_CHAT,
        SC_CHANGE_USER_LIST,
        CS_CREATE_INVITE_CHANNEL = 121,
        SC_CREATE_INVITE_CHANNEL,
        CS_INVITE_USER,
        SC_INVITE_USER,
        SC_RECV_INVITE_USER,
        CS_REPLY_INVITE_USER,
        SC_REPLY_INVITE_USER,
        CS_CANCEL_INVITE_USER,
        SC_CANCEL_INVITE_USER,
        SC_RECV_CANCEL_INVITE_USER,
        SC_INVITE_CHANNEL_JOIN_USER,
        SC_INVITE_CHANNEL_DENY_USER,
        CS_LEAVE_INVITE_CHANNEL = 134,
        SC_LEAVE_INVITE_CHANNEL,
        SC_INVITE_CHANNEL_LEAVE_USER,
        SC_DESTROY_INVITE_CHANNEL,
        CS_INVITE_CHANNEL_KICKOUT_USER,
        SC_INVITE_CHANNEL_KICKOUT_USER,
        SC_RECV_INVITE_CHANNEL_KICKOUT_USER,
        CS_INVITE_CHANNEL_GRANT,
        SC_INVITE_CHANNEL_GRANT,
        SC_RECV_INVITE_CHANNEL_GRANT,
        CS_INVITE_CHANNEL_REVOKE,
        SC_INVITE_CHANNEL_REVOKE,
        SC_RECV_INVITE_CHANNEL_REVOKE,
        CS_SEND_CHANNEL_CHAT,
        SC_SEND_CHANNEL_CHAT,
        SC_RECV_CHANNEL_CHAT,
        SC_INVITE_CHANNEL_CHANGE_USER_LIST,
        CS_CHANGE_CHANNEL_CONFIG = 157,
        SC_CHANGE_CHANNEL_CONFIG,
        CS_INVITE_CHANNEL_CHANGE_TEAM,
        SC_INVITE_CHANNEL_CHANGE_TEAM,
        SC_RECV_INVITE_CHANNEL_CHANGE_TEAM,
        CS_INVITE_CHANNEL_ADD_AI_USER,
        SC_INVITE_CHANNEL_ADD_AI_USER,
        CS_INVITE_CHANNEL_DEL_AI_USER,
        SC_INVITE_CHANNEL_DEL_AI_USER,
        CS_INVITE_CHANNEL_CHANGE_AI_USER,
        SC_INVITE_CHANNEL_CHANGE_AI_USER,
        CS_INVITE_CHANNEL_GAME_START,
        SC_INVITE_CHANNEL_GAME_START,
        CS_PUBLISHER_CASH = 181,
        SC_PUBLISHER_CASH,
        CS_BUY_PRODUCT,
        SC_BUY_PRODUCT,
        CS_CHANGE_USERNAME,
        SC_CHANGE_USERNAME,
        CS_PRESENT_TO_USER,
        SC_PRESENT_TO_USER,
        CS_PURCHASE_LIST,
        SC_PURCHASE_LIST,
        SC_RECEIVE_PRESENT_FROM_USER,
        CS_USE_COUPON,
        SC_USE_COUPON,
        CS_ATTENDANCE_REWARD,
        SC_ATTENDANCE_REWARD,
        CS_USE_EXCHANGE_TICKET,
        SC_USE_EXCHANGE_TICKET,
        SC_SEND_NEXON_MESSAGE = 201,
        SC_SEND_SHUTDOWN_TIME,
        SC_SEND_PCBANG_BENEFIT_TYPE,
        SC_SEND_NEXON_SHOP_DATA = 211,
        CS_PURCHASE_DETERMINE = 216,
        SC_PURCHASE_DETERMINE,
        CS_PURCHASE_CANCEL,
        SC_PURCHASE_CANCEL,
        CS_NGS_SECURE_PACKET,
        SC_NGS_SECURE_PACKET,
        CS_REQ_NXA_TICKET,
        SC_REQ_NXA_TICKET,
        CS_REQ_STEAM_DLC_CHECK,
        SC_REQ_STEAM_DLC_CHECK,
        CS_REQ_REGION_INFO,
        SC_REQ_REGION_INFO,
        SC_STEAM_DLC_LIST,
        CS_LABORATORY_CUBE_OPEN = 230,
        SC_LABORATORY_CUBE_OPEN,
        CS_LABORATORY_DECOMPOSITION,
        SC_LABORATORY_DECOMPOSITION,
        CS_LABORATORY_PRODUCT_ITEM,
        SC_LABORATORY_PRODUCT_ITEM,
        CS_LABORATORY_COMPOUND,
        SC_LABORATORY_COMPOUND,
        CS_LABORATORY_CUBE_COMPOUND,
        SC_LABORATORY_CUBE_COMPOUND
    }
}
