using System;

public struct SkillBuffID : IComparable<SkillBuffID>, IEquatable<SkillBuffID>
{
    public SkillBuffID(SkillResultID skillResultID_1, int int_1)
    {
        this.skillResultID_0 = skillResultID_1;
        this.int_0 = int_1;
    }

    public SkillBuffID(SkillID skillID_0, int int_1, int int_2)
    {
        this.skillResultID_0 = new SkillResultID(skillID_0, int_1);
        this.int_0 = int_2;
    }

    public SkillBuffID(SkillBuffID skillBuffID_1)
    {
        this.skillResultID_0 = skillBuffID_1.skillResultID_0;
        this.int_0 = skillBuffID_1.int_0;
    }

    public SkillBuffID(string string_0)
    {
        string[] array = string_0.Split(new char[]
        {
            '_'
        });
        if (array.Length != 3)
        {
            this.skillResultID_0 = SkillResultID.skillResultID_0;
            this.int_0 = 0;
            //GInstance.GLog.logFuncType_2(string.Format("[SkillInfo] SkillBuffID Error. {0}", string_0));
        }
        else
        {
            this.skillResultID_0 = new SkillResultID(new SkillID(array[0]), int.Parse(array[1]));
            this.int_0 = int.Parse(array[2]);
        }
    }

    public override string ToString()
    {
        return string.Format("{0}_{1}", this.skillResultID_0.ToString(), this.int_0);
    }

    public bool Equals(SkillBuffID other)
    {
        return SkillBuffID.smethod_0(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is SkillBuffID && SkillBuffID.smethod_0(this, (SkillBuffID)obj);
    }

    public override int GetHashCode()
    {
        return this.skillResultID_0.GetHashCode() ^ this.int_0;
    }

    public int CompareTo(SkillBuffID other)
    {
        int num = this.skillResultID_0.CompareTo(other.skillResultID_0);
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

    public static bool smethod_0(SkillBuffID skillBuffID_1, SkillBuffID skillBuffID_2)
    {
        return SkillResultID.smethod_0(skillBuffID_1.skillResultID_0, skillBuffID_2.skillResultID_0) && skillBuffID_1.int_0 == skillBuffID_2.int_0;
    }

    public static bool smethod_1(SkillBuffID skillBuffID_1, SkillBuffID skillBuffID_2)
    {
        return !SkillBuffID.smethod_0(skillBuffID_1, skillBuffID_2);
    }

    public readonly SkillResultID skillResultID_0;

    public readonly int int_0;

    public static readonly SkillBuffID skillBuffID_0 = default(SkillBuffID);
}
