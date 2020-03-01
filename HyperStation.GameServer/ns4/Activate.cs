using System;
using System.Xml;
using HyperStation.GameServer;

namespace ns4
{
    public class Activate : XmlClass, IAddable<Activate>
    {
        public Activate()
        {
        }

        public Activate(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public Activate(Activate other)
        {
            this._Type = other._Type;
            this._StatCondition = other._StatCondition;
            this._TargetHPRatio = other._TargetHPRatio;
            this._RatioType = other._RatioType;
            this._DamageAmplifyRatio = other._DamageAmplifyRatio;
            this._StartDelay = other._StartDelay;
            this._BuffID = other._BuffID;
            this._TickTime = other._TickTime;
            this._Prob = other._Prob;
            this._BattlePawnType = other._BattlePawnType;
            this._KillCount = other._KillCount;
        }

        public void Add(Activate other)
        {
            if (other == null)
            {
                return;
            }
            Util.smethod_2(ref this._TickTime, other._TickTime);
            Util.smethod_0(ref this._DamageAmplifyRatio, other._DamageAmplifyRatio);
            Util.smethod_2(ref this._Prob, other._Prob);
            Util.smethod_2(ref this._StartDelay, other._StartDelay);
            Util.smethod_1(ref this._TargetHPRatio, other._TargetHPRatio, 100);
            Util.smethod_1(ref this._KillCount, other._KillCount, 0);
        }

        [global::Xml("Type")]
        public Activate.Type _Type;

        [global::Xml("StatCondition")]
        public StatCondition _StatCondition;

        [global::Xml("TargetRatioType")]
        public Activate.RatioType _RatioType;

        [global::Xml("TargetHPRatio")]
        public int _TargetHPRatio = 100;

        [global::Xml("TargetMPRatio")]
        public int _TargetMPRatio = 100;

        [global::Xml("DamageAmplifyRatio")]
        public int _DamageAmplifyRatio;

        [global::Xml("StartDelay")]
        public float _StartDelay;

        [global::Xml("BuffID")]
        public SkillBuffID _BuffID = SkillBuffID.skillBuffID_0;

        [global::Xml("BattlePawnType")]
        public PawnType _BattlePawnType;

        [global::Xml("TickTime")]
        public float _TickTime;

        [global::Xml("Prob")]
        public float _Prob;

        [global::Xml("KillCount")]
        public int _KillCount;

        public enum RatioType
        {
            Invalid,
            Under,
            Over
        }

        public enum Type : byte
        {
            None,
            Spawn,
            Respawn,
            SpawnBuff,
            Time,
            Attack,
            AttackEnemyHero,
            AttackMonster,
            AttackMinionMonster,
            AttackBuilding,
            BaseAttack,
            SkillUse,
            KillHero,
            KillHeroOnly,
            AssistHeroOnly,
            KillMonster,
            KillMinionMonster,
            KillMinionMonsterByTeam,
            Die,
            RespawnTime,
            HPRatio,
            MPRatio,
            NonBattle,
            Hit,
            HitTower,
            HitEnemyHero,
            MesHit,
            MesHitAfter,
            AccessoryUpgrade,
            ChangeHero,
            BuffStackCount,
            Critical,
            StatOver,
            StatUnder,
            SkillDamAmplifyByHPRatio,
            KillCount,
            DeathHero,
            DeathAllyHero,
            DeathEnemyHero
        }
    }
}
