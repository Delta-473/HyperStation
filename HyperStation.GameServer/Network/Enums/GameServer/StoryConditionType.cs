using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum StoryConditionType
    {
        StoryConType_AccountLevel = 1,
        StoryConType_AccountExp,
        StoryConType_TotalMatch,
        StoryConType_TotalWin,
        StoryConType_TotalLose,
        StoryConType_TotalHyperKill,
        StoryConType_TotalDeath,
        StoryConType_TotalAssist,
        StoryConType_TotalUnitKill,
        StoryConType_TotalTowerDestroy,
        StoryConType_TotalGameGold,
        StoryConType_TotalGameExp,
        StoryConType_TotalItemBox,
        StoryConType_TotalHealing,
        StoryConType_TotalDamageDone,
        StoryConType_TotalDamageTaken,
        StoryConType_TotalMaxWinStreak,
        StoryConType_TotalMaxHyperKillStreak,
        StoryConType_MatchMaxHyperKill,
        StoryConType_MatchMaxDeath,
        StoryConType_MatchMaxAssist,
        StoryConType_MatchGameGold,
        StoryConType_MatchItemBox,
        StoryConType_HyperLevel,
        StoryConType_HyperExp,
        StoryConType_StoryID,
        StoryConType_SelectCount,
        StoryConType_HyperSkin,
        StoryConType_RecommendAchieveCount,
        StoryConType_LikeCount
    }
}
