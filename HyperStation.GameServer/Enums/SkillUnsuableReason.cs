using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperStation.GameServer
{
    public enum SkillUnusableReason : byte
    {
        None,
        JumpAvailable,
        MPCon,
        HPCon,
        GoldCon,
        Cooldown,
        ForbidState,
        AirBaseAttackCount,
        InstantAvail,
        SkillStack,
        BuffMax,
        Level,
        Deny,
        AttackType,
        Special1,
        Special2,
        Unknown
    }
}
