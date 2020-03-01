using System;
using System.Collections.Generic;

public static class PawnState
{
    public static bool smethod_0(PawnState.StateType stateType_0)
    {
        return stateType_0 == PawnState.StateType.Ladder || stateType_0 == PawnState.StateType.LadderExitTop || stateType_0 == PawnState.StateType.LadderAttachTop || stateType_0 == PawnState.StateType.LadderUpJump;
    }

    public static bool smethod_1(PawnState.StateType stateType_0, PawnState.StateType stateType_1)
    {
        return PawnState.smethod_0(stateType_1) || stateType_1 == PawnState.StateType.LadderAttachTopWait || (stateType_0 == PawnState.StateType.LadderAttachTop && stateType_1 == PawnState.StateType.Fall);
    }

    public static bool smethod_2(PawnState.StateType stateType_0)
    {
        switch (stateType_0)
        {
            case PawnState.StateType.Fall:
            case PawnState.StateType.Jump:
            case PawnState.StateType.Ladder:
            case PawnState.StateType.LadderExitTop:
            case PawnState.StateType.LadderAttachTop:
            case PawnState.StateType.LadderUpJump:
            case PawnState.StateType.HighJump:
                return true;
            default:
                return false;
        }
    }

    public static readonly PawnState.StateTypeComparer stateTypeComparer_0 = new PawnState.StateTypeComparer();

    public enum StateType : byte
    {
        None,
        Idle,
        AttackIdle,
        Hover,
        Die,
        Fall,
        Move,
        Jump,
        TriggerJump,
        Ladder,
        LadderExitTop,
        LadderAttachTop,
        LadderUpJump,
        LadderAttachTopWait,
        LadderShake,
        HighJump,
        Land,
        Skill,
        Crouch,
        Sleep,
        WakeUp,
        Deadly,
        Spawn,
        MoveUnderGround,
        StandByHighJump,
        SocialMotion
    }

    public class StateTypeComparer : IEqualityComparer<PawnState.StateType>
    {
        public bool Equals(PawnState.StateType a, PawnState.StateType b)
        {
            return a == b;
        }

        public int GetHashCode(PawnState.StateType obj)
        {
            return (int)obj;
        }
    }
}
