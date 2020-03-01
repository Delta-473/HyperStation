using System;

public struct SkillOptionID : IComparable<SkillOptionID>, IEquatable<SkillOptionID>
{
    public SkillOptionID(string string_0)
    {
        this.uint_0 = Convert.ToUInt32(string_0);
    }

    public SkillOptionID(uint uint_1)
    {
        this.uint_0 = uint_1;
    }

    public override string ToString()
    {
        return this.uint_0.ToString();
    }

    public uint method_0()
    {
        return this.uint_0;
    }

    public override int GetHashCode()
    {
        return this.uint_0.GetHashCode();
    }

    public bool Equals(SkillOptionID other)
    {
        return SkillOptionID.smethod_0(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is SkillOptionID && SkillOptionID.smethod_0(this, (SkillOptionID)obj);
    }

    public int CompareTo(SkillOptionID other)
    {
        if (this.uint_0 < other.uint_0)
        {
            return -1;
        }
        if (this.uint_0 > other.uint_0)
        {
            return 1;
        }
        return 0;
    }

    public static bool smethod_0(SkillOptionID skillOptionID_1, SkillOptionID skillOptionID_2)
    {
        return skillOptionID_1.uint_0 == skillOptionID_2.uint_0;
    }

    public static bool smethod_1(SkillOptionID skillOptionID_1, SkillOptionID skillOptionID_2)
    {
        return !SkillOptionID.smethod_0(skillOptionID_1, skillOptionID_2);
    }

    private readonly uint uint_0;

    public static readonly SkillOptionID skillOptionID_0 = default(SkillOptionID);
}
