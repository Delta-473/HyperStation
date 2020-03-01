using System;

namespace HyperStation.GameServer
{
    public enum PawnType : byte
    {
        Invalid,
        Hero,
        Minion = 10,
        Monster = 20,
        Summoned = 30,
        Building = 100
    }
}
