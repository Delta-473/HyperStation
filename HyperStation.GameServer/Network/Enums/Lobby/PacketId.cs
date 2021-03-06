﻿using System;

namespace HyperStation.GameServer.Network.Packet.Lobby
{
    public enum PacketId
    {
        CS_LOAD_USER_DATA = 1,
        SC_LOAD_USER_DATA,
        CS_GET_ITEM_BOOSTER,
        SC_GET_ITEM_BOOSTER,
        CS_FIND_USERINFO,
        SC_FIND_USERINFO,
        CS_GET_ROTATION_HYPER,
        SC_GET_ROTATION_HYPER,
        CS_SET_KEYS = 11,
        SC_SET_KEYS,
        CS_SET_GAME_OPTIONS,
        SC_SET_GAME_OPTIONS,
        CS_SET_GROUP_ORDER,
        SC_SET_GROUP_ORDER,
        CS_SET_CHANNEL_LIST,
        SC_SET_CHANNEL_LIST,
        CS_SET_EQUIP = 21,
        SC_SET_EQUIP,
        CS_CLEAR_EQUIP,
        SC_CLEAR_EQUIP,
        CS_GET_PING_SETTING = 35,
        SC_GET_PING_SETTING,
        CS_SET_PING_SETTING,
        SC_SET_PING_SETTING,
        CS_SET_REPRESENTATIVE_EMBLEM = 41,
        SC_SET_REPRESENTATIVE_EMBLEM,
        CS_UPDATE_ACHIEVEMENT_NOTIFY_DATE = 51,
        SC_UPDATE_ACHIEVEMENT_NOTIFY_DATE,
        CS_UPDATE_MESSAGE_CHECK_DATE,
        SC_UPDATE_MESSAGE_CHECK_DATE,
        CS_UPDATE_PRESENT_CHECK_DATE,
        SC_UPDATE_PRESENT_CHECK_DATE,
        CS_GET_USER_LOG_MESSAGE = 61,
        SC_GET_USER_LOG_MESSAGE,
        CS_GET_EVENTBUFF_LIST,
        SC_GET_EVENTBUFF_LIST,
        CS_GET_CONTENTS_RESTRICT_LIST,
        SC_GET_CONTENTS_RESTRICT_LIST,
        CS_GET_LABORATORY_ITEM_LIST,
        SC_GET_LABORATORY_ITEM_LIST,
        CS_GET_RANKING_DATA = 71,
        SC_GET_RANKING_DATA,
        CS_GET_MY_RANKING_DATA,
        SC_GET_MY_RANKING_DATA,
        CS_GET_ITEM_PREFER_LIST,
        SC_GET_ITEM_PREFER_LIST,
        CS_GET_TOP_RANK_BATTLE_LIST,
        SC_GET_TOP_RANK_BATTLE_LIST,
        CS_GET_RECENT_PLAY_DETAIL_INFO = 81,
        SC_GET_RECENT_PLAY_DETAIL_INFO
    }
}
