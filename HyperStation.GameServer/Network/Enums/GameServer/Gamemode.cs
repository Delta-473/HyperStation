using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum GameMode
    {
        CUSTOM_MODE = 1,
        NORMAL_MODE,
        NEWBIE_MODE,
        PRACTICE_MODE,
        TUTORIAL_MODE,
        AI_MODE,
        AI_HIGH_MODE,
        CONQUEST_MODE,
        AI_CONQUEST_MODE,
        TROLL_MODE,
        DEATH_MATCH_MODE,
        SOLO_RANK_MODE = 21,
        DUO_RANK_MODE,
        TRIO_RANK_MODE,
        QUARTET_RANK_MODE
    }
}