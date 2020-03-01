using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum ItemChangeType
    {
        ICT_DefaultGive = 100,
        ICT_LevelUpReward,
        ICT_GameReward,
        ICT_ShopBuy,
        ICT_Present,
        ICT_AchieveReward,
        ICT_StoryReward,
        ICT_DailyPCBangReward,
        ICT_SeasonPCBangReward,
        ICT_AttendanceReward,
        ICT_AddGMTool,
        ICT_DelGMTool,
        ICT_LaboratoryDecompostion,
        ICT_LaboratoryProduct,
        ICT_LaboratoryCompound,
        ICT_UseItem,
        ICT_CubeOpen,
        ICT_CubeOpenBonus,
        ICT_ExchangeTicket,
        ICT_RankReward,
        ICT_Cheat,
        ICT_ShopBuy_GPBonus,
        ICT_LaboratorySampleDecomposition,
        ICT_AchievePeriodReward
    }
}
