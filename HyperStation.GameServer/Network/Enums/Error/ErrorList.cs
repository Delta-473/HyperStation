﻿using System;

namespace HyperStation.GameServer.Network.Packet.Error
{
    public enum ErrorList
    {
        ERROR_NONE,
        ERR_WRONG_PASSWORD,
        ERR_LOGIN_AUTH_FAILED,
        ERR_SESSION_AUTH_FAILED,
        ERR_GENERATE_KEY_FAILED,
        ERR_INVALID_USER_DATA,
        ERR_LOGIN_FAILED,
        ERR_NO_VACANCY,
        ERR_ALREADY_CLOSED,
        ERR_KICKOUT_LOGIN_USER,
        ERR_LOGIN_USER_NOT_FOUND,
        ERR_IN_MAINTENANCE,
        ERR_STRING_OVERFLOW,
        ERR_USERNAME_BADWORD,
        ERR_USERNAME_RULE_BREAK,
        ERR_CONNECT_REQUEST_DENY_IP,
        ERR_OVER_SEND_REPORT_LIMIT,
        ERR_CHAT_ROOM_FAILED = 100,
        ERR_CHAT_ROOM_CONNECT_FAILED,
        ERR_CHAT_ROOM_CREATE_FAILED,
        ERR_CHAT_ROOM_ENTER_FAILED,
        ERR_CHAT_ROOM_FULL,
        ERR_INVALID_USER,
        ERR_SEND_CHAT_FAILED,
        ERR_ALREADY_ENTERED,
        ERR_NO_FREE_CHAT_ROOM,
        ERR_NOT_JOINED_ROOM,
        ERR_CHAT_ROOM_EXCEED_MAX_ROOM,
        ERR_INVITE_CHAT_NO_RELATION,
        ERR_INVITE_CHAT_ALREADY_JOINED,
        ERR_START_MATCH_FAILED = 200,
        ERR_CANNOT_START_MATCH,
        ERR_CANNOT_CANCEL_MATCH,
        ERR_CREATE_BATTLE_FAILED,
        ERR_GAME_RESULT_NOT_COMPLETE,
        ERR_CANNOT_START_GAME,
        ERR_CANNOT_FIND_RECONNECT_INFO,
        ERR_RECONNECT_AUTH_FAILED,
        ERR_INVALID_GAME_MODE,
        ERR_CANNOT_START_WITH_TEAM,
        ERR_CANNOT_FIND_MATCH_MODE,
        ERR_CANNOT_FIND_BATTLE_INFO,
        ERR_END_OF_GAMES,
        ERR_RECONNECT_TYPE_MISMATCHED,
        ERR_IN_PENALTY,
        ERR_INVALID_ESCAPE_TYPE,
        ERR_ALREADY_EVALUATED,
        ERR_CANNOT_EVALUATE_SELF,
        ERR_USER_LEVEL_RESTRICT,
        ERR_INVALID_MATCH_MODE,
        ERR_INVLAID_GAME_OPTION,
        ERR_TARGET_USER_LEVEL_RESTRICT,
        ERR_NOT_ENOUGH_HYPER_COUNT,
        ERR_INVALID_REGION_CODE,
        ERR_CANNOT_SELECT_REGION_CODE,
        ERR_HYPER_SET_FAILED = 300,
        ERR_INVALID_ITEM_OR_SLOT,
        ERR_ITEM_COMBINE_IS_INVALID,
        ERR_CANNOT_CHANGE_PCBANG_SLOT,
        ERR_SLOT_IS_NOT_OWNED,
        ERR_CANNOT_CHANGE_USER_STATE = 400,
        ERR_CANNOT_CHANGE_USERNAME,
        ERR_USER_STATE_FAILED,
        ERR_INVALID_TUTORIAL_STEP,
        ERR_CHAT_BLOCK,
        ERR_INVITE_CHANNEL_FAILED = 500,
        ERR_CREATE_INVITE_CHANNEL_FAILED,
        ERR_ALREADY_JOINED_INVITE_CHANNEL,
        ERR_CHANNEL_NOT_FOUND,
        ERR_CHANNEL_PERMISSION_DENIED,
        ERR_TARGET_USER_ALREADY_INVITED,
        ERR_TARGET_USER_NOT_FOUND,
        ERR_TARGET_USER_BUSY,
        ERR_NOT_INVITED_USER,
        ERR_CHANNEL_FULL,
        ERR_CHANNEL_CHAT_FAILED,
        ERR_CHANNEL_JOIN_FAILED,
        ERR_CHANNEL_LEAVE_FAILED,
        ERR_CANNOT_START_CHANNEL_GAME,
        ERR_CHANNEL_WAIT_USER_EXISTS,
        ERR_CHANNEL_INDEX_OCCUPIED,
        ERR_NOT_JOINED_CHANNEL,
        ERR_CANNOT_CREATE_CHANNEL,
        ERR_INVITE_CHANNEL_AI_FAILED,
        ERR_INVITE_CHANNEL_AI_ADD_FAILED,
        ERR_INVITE_CHANNEL_AI_DEL_FAILED,
        ERR_INVITE_CHANNEL_AI_DUPLICATE,
        ERR_INVITE_CHANNEL_AI_CHANGE_FAILED,
        ERR_CANNOT_CREATE_BATTLE,
        ERR_BATTLE_PROCESS_ERROR,
        ERR_CANNOT_JOIN_CHANNEL,
        ERR_INVITE_CHANNEL_NO_RELATION,
        ERR_INVITE_CHANNEL_NOT_JOINED_USER,
        ERR_INVITE_CHANNEL_KICKOUT_FAILED,
        ERR_CANNOT_INVITE_USER,
        ERR_INVITE_CHANNEL_ALREADY_GRANTED,
        ERR_INVITE_CHANNEL_NOT_GRANTED,
        ERR_INVALID_CHANNEL_OPTION,
        ERR_CANNOT_CHANGE_OPTIONS,
        ERR_INVITE_CHANNEL_IN_PENALTY,
        ERR_INVITE_CHANNEL_PENALTY_SELF,
        ERR_INVALID_MATCH_USER_COUNT,
        ERR_INVALID_GAME_USER_COUNT,
        ERR_PRIVATE_CHANNEL_ALREADY_CREATED = 550,
        ERR_GAMEROOM_FAILED = 601,
        ERR_GAMEROOM_NOT_READY,
        ERR_CANNOT_CHANGE_STATE,
        ERR_DUPLICATE_HYPER,
        ERR_CHAT_FAILED,
        ERR_GAME_NOT_END,
        ERR_CANNOT_FIND_USER,
        ERR_INVALID_HYPER_DATA,
        ERR_HYPER_NOT_OWNED,
        ERR_HYPER_NOT_SELECTABLE,
        ERR_SKIN_NOT_OWNED,
        ERR_NOT_ON_YOUR_TURN,
        ERR_CANNOT_BAN_IN_THIS_PICKMODE,
        ERR_ON_TRADE_HYPER,
        ERR_CANNOT_TRADE_HYPER,
        ERR_INVALID_TRADE_TARGET,
        ERR_INVALID_ROOM_STATE,
        ERR_HYPER_TRADE_REJECTED,
        ERR_OBSERVE_FAILED = 671,
        ERR_OBSERVE_INVALID_TARGET_USER,
        ERR_OBSERVE_GAME_NOT_FOUND,
        ERR_OBSERVE_INVALID_GAME_MODE,
        ERR_OBSERVE_GAME_NOT_PROCESS,
        ERR_OBSERVE_GAME_END,
        ERR_OBSERVE_GAME_FULL,
        ERR_OBSERVE_TRY_AGIN = 687,
        ERR_OBSERVER_NOT_AVAILABLE,
        ERR_COMMUNITY_FAILED = 701,
        ERR_COMMUNITY_NOT_INVITED,
        ERR_COMMUNITY_EXCEED_MAX_FRIEND,
        ERR_COMMUNITY_NO_RELATION,
        ERR_COMMUNITY_ALREADY_FRIEND,
        ERR_COMMUNITY_ALREADY_INVITED,
        ERR_COMMUNITY_EXCEED_MAX_GROUP,
        ERR_COMMUNITY_GROUP_NOT_EXISTS,
        ERR_COMMUNITY_ALREADY_BANNED,
        ERR_COMMUNITY_USER_NOT_BANNED,
        ERR_COMMUNITY_EXCEED_MAX_BAN,
        ERR_COMMUNITY_USER_BANNED,
        ERR_COMMUNITY_LOGOUT_FRIEND,
        ERR_COMMUNITY_SELF_TARGETING,
        ERR_COMMUNITY_GM,
        ERR_COMMUNITY_CANNOT_FIND_USER = 719,
        ERR_INVALID_ITEM_DATA = 801,
        ERR_GM_REDIS_ERROR = 900,
        ERR_GM_INVALID_PARAM = 902,
        ERR_GM_INVALID_METHOD,
        ERR_GM_INVALID_URI,
        ERR_GM_SYSTEM_ERR,
        ERR_GM_INVALID_DATE,
        ERR_GM_INVALID_TYPE,
        ERR_GM_TOO_MANY_REQUEST,
        ERR_GM_USER_NOT_FOUND,
        ERR_GM_ALREADY_ITEM_EXIST,
        ERR_GM_RESERVED_COMMAND_DUPLICATE_COMMAND,
        ERR_GM_RESERVED_COMMAND_DUPLICATE_DATE,
        ERR_GM_NOT_PLAY_GAMEMODE_MAP,
        ERR_GOODS_ALREADY_EXISTS = 1000,
        ERR_NOT_ENOUGH_GAME_MONEY,
        ERR_ALREADY_IN_BUYING,
        ERR_INVALID_PURCHASE_WAY,
        ERR_INVALID_PRODUCT_DATA,
        ERR_NOT_FOR_SALE,
        ERR_NOT_ENOUGH_HYPER_POINT,
        ERR_INVALID_MONEY_INFO,
        ERR_NOT_ENOUGH_PUBLISHER_CASH,
        ERR_OVER_MONTHLY_LIMIT,
        ERR_SOLD_OUT,
        ERR_OVER_DAILY_LIMIT,
        ERR_OVERLAPPED_PURCHASE_ID,
        ERR_NOT_ENOUGH_CASH,
        ERR_CANNOT_REFUND_PRODUCT,
        ERR_COUNT_NOT_MATCHED,
        ERR_REFUND_DATE_EXPIRED,
        ERR_ALREADY_DETERMINED,
        ERR_PRODUCT_COST_IS_ZERO,
        ERR_NOT_PRESENTABLE,
        ERR_BUY_FAILED,
        ERR_COULD_NOT_LOAD_CASH,
        ERR_COULD_NOT_RECEIVE_PRODUCT,
        ERR_REFUND_FAILED,
        ERR_PRESENT_FAILED,
        ERR_WRITE_PURCHASE_LIST_FAILED,
        ERR_LOAD_CASH_INVENTORY_FAILED,
        ERR_PRODUCT_LIST_LOAD_FAILED,
        ERR_CATEGORY_LOAD_FAILED,
        ERR_PURCHASE_CONFIRM_FAILED,
        ERR_CASH_IS_LOCKED,
        ERR_CANNOT_PRESENT_SELF,
        ERR_NOT_IN_PCBANG = 1100,
        ERR_ALREADY_GET_REWARD,
        ERR_NOT_ENOUGH_PCBANG_TIME,
        ERR_PCBANG_TIME_REWARD_IS_NOTHING,
        ERR_NOT_ON_PCBANG_SEASON,
        ERR_INVALID_GIFT_TERM,
        ERR_RESTRICT_LOGIN = 1200,
        ERR_STORY_ALREADY_ACHIEVED = 1300,
        ERR_STORY_RESOURCE_NOT_FOUND,
        ERR_STORY_ACHIEVED_FAIL,
        ERR_CANNOT_USE_COUPON = 1400,
        ERR_COUPON_1,
        ERR_COUPON_2,
        ERR_COUPON_6,
        ERR_COUPON_98,
        ERR_COUPON_99,
        ERR_COUPON_501,
        ERR_COUPON_502,
        ERR_COUPON_504,
        ERR_COUPON_511,
        ERR_COUPON_512,
        ERR_COUPON_515,
        ERR_COUPON_516,
        ERR_COUPON_517,
        ERR_COUPON_522,
        ERR_COUPON_531,
        ERR_COUPON_532,
        ERR_COUPON_541,
        ERR_COUPON_550,
        ERR_COUPON_571,
        ERR_COUPON_599,
        ERR_LABORATORY_WAIT_FOR_COMPLETE = 1500,
        ERR_LABORATORY_NOT_FIND_CRAFTITEM,
        ERR_LABORATORY_NOT_ENOUGH_MATERIAL,
        ERR_LABORATORY_NOT_ENOUGH_CUBE,
        ERR_LABORATORY_NOT_FIND_CUBE,
        ERR_LABORATORY_NOT_FIND_DECOMPOSITION,
        ERR_LABORATORY_NOT_FIND_MATERIAL,
        ERR_LABORATORY_NOT_FIND_COMPOUND,
        ERR_LABORATORY_NOT_FIND_COMPOUND_RESULT,
        ERR_SECURE_USERLOGIN_FAILED = 1600,
        ERR_ATTENDANCE_REWARD_NOTHING = 1700,
        ERR_ATTENDANCE_REWARD_ALREADY_RECEIVED,
        ERR_ATTENDANCE_REWARD_ON_PROCESS,
        ERR_ATTENDANCE_REWARD_DISABLED,
        DB_ERROR = 10000,
        DB_ERR_NOT_EXIST_ACCOUNT,
        DB_ERR_EXIST_ACCOUNT,
        DB_ERR_ALREADY_LOGIN,
        DB_ERR_CREATE_ACCOUNT_FAIL,
        DB_ERR_EXIST_USERNAME,
        DB_ERR_NOT_EXIST_USER,
        DB_ERR_EXCEED_MAX_FRIEND,
        DB_ERR_EXCEED_MAX_INVITATION,
        DB_ERR_FRIEND_ALREADY_INVITE,
        DB_ERR_ALREADY_FRIEND,
        DB_ERR_GROUP_NOT_EXISTS,
        DB_ERR_USER_NOT_BANNED,
        DB_ERR_USER_IS_GM,
        DB_ERR_BANNED_BY_TARGET_USER,
        DB_ERR_ALREADY_COMPLETE_STORY,
        DB_ERR_ALREADY_REPRESENTATIVE_EMBLEM_OPEN,
        DB_ERR_NOT_EXIST_EMBLEM,
        DB_ERR_NOT_OPEN_REPRESENTATIVE_EMBLEM_SLOT,
        DB_ERR_RESERVED_COMMAND_DUPLICATE_TYPE,
        DB_ERR_RESERVED_COMMAND_DUPLICATE_DATE,
        DB_ERR_NOT_ENOUGH_ITEM,
        DB_ERR_ITEMHAVE_FAILED,
        DB_ERR_LABORATORY_ITEMTYPE_NOT_DEFINE,
        DB_ERR_NOT_ENOUGH_MONEY,
        DB_ERR_CANNOT_FOUND_DATA,
        ERR_NEXON_AUTH_FAILED = 20000,
        ERR_NEXON_NONE_IDENTIFY,
        ERR_NEXON_AGE_NOT_AVAILABLE,
        ERR_STEAM_GET_USERINFO_FAILED,
        ERR_NOT_STEAM_USER,
        ERR_NOT_EARLY_ACCESS_USER,
        ERR_ALREADY_DLC_PROC,
        ERR_NOT_FIND_PURCHASE_APP,
        ERR_ALREADY_PRUCHASE_APP,
        ERR_SYSTEM_FAILED = 30000,
        ERR_SYSTEM_ECONNRESET,
        ERR_MASTER_AUTH_FAILED,
        ERR_MANAGER_AUTH_FAILED,
        ERR_LOAD_RESOURCE_FAILED,
        ERR_MATCH_AUTH_FAILED,
        ERR_BATTLE_ROOM_AUTH_FAILED,
        ERR_CANNOT_FIND_LOG_SERVER,
        ERR_CANNOT_FIND_LOBBY_SERVER,
        ERR_CANNOT_FIND_SESSION_SERVER,
        ERR_CANNOT_FIND_BATTLE_SERVER,
        ERR_CANNOT_FIND_CHAT_SERVER,
        ERR_CANNOT_FIND_MATCH_SERVER
    }
}
