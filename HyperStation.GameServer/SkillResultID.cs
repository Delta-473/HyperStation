using System;

public struct SkillResultID : IComparable<SkillResultID>, IEquatable<SkillResultID>
{
    public readonly SkillID skillID_0;
    public readonly int int_0;
    public static readonly SkillResultID skillResultID_0 = default(SkillResultID);

    public SkillResultID(SkillID skillID_1, int int_1)
    {
        this.skillID_0 = skillID_1;
        this.int_0 = int_1;
    }

    public override string ToString()
    {
        return string.Format("{0}_{1}", this.skillID_0.ToString(), this.int_0);
    }

    public bool Equals(SkillResultID other)
    {
        return SkillResultID.smethod_0(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is SkillResultID && SkillResultID.smethod_0(this, (SkillResultID)obj);
    }

    public override int GetHashCode()
    {
        return this.skillID_0.GetHashCode() ^ this.int_0;
    }

    public int CompareTo(SkillResultID other)
    {
        int num = this.skillID_0.CompareTo(other.skillID_0);
        if (num != 0)
        {
            return num;
        }
        if (this.int_0 < other.int_0)
        {
            return -1;
        }
        if (this.int_0 > other.int_0)
        {
            return 1;
        }
        return 0;
    }

    public static bool smethod_0(SkillResultID skillResultID_1, SkillResultID skillResultID_2)
    {
        return skillResultID_1.skillID_0 == skillResultID_2.skillID_0 && skillResultID_1.int_0 == skillResultID_2.int_0;
    }

    public static bool smethod_1(SkillResultID skillResultID_1, SkillResultID skillResultID_2)
    {
        return !SkillResultID.smethod_0(skillResultID_1, skillResultID_2);
    }

    
}
