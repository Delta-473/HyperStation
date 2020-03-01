using System;


namespace HyperStation.GameServer
{
    public static class SC_SkillHitResultDefine
    {
        [Flags]
        public enum MainDataFlag : byte
        {
            None = 0,
            Projectile = 1,
            Damage = 2,
            MoveX = 4,
            MoveY = 8,
            HitDir = 16
        }

        [Flags]
        public enum SubDataFlag : byte
        {
            None = 0,
            Splash = 1,
            FirstValidResultHit = 2,
            FirstValidSkillDamage = 4,
            FirstValidPawnDamage = 8,
            FirstValidResultDamage = 16,
            FirstValidSkillDamageInDetection = 32
        }
    }
}
