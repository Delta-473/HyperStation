using System;

public struct ObjectUID : IComparable<ObjectUID>, IEquatable<ObjectUID>
{
    public ObjectUID(string string_0)
    {
        this.short_0 = Convert.ToInt16(string_0);
    }

    public ObjectUID(short short_1)
    {
        this.short_0 = short_1;
    }

    public ObjectUID(ObjectUID objectUID_1)
    {
        this.short_0 = objectUID_1.short_0;
    }

    public override string ToString()
    {
        return this.short_0.ToString();
    }

    public short method_0()
    {
        return this.short_0;
    }

    public override int GetHashCode()
    {
        return this.short_0.GetHashCode();
    }

    public bool Equals(ObjectUID other)
    {
        return ObjectUID.smethod_1(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is ObjectUID && ObjectUID.smethod_1(this, (ObjectUID)obj);
    }

    public int CompareTo(ObjectUID other)
    {
        return this.short_0.CompareTo(other.short_0);
    }

    public static int smethod_0(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return objectUID_1.CompareTo(objectUID_2);
    }

    public static bool smethod_1(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return objectUID_1.short_0 == objectUID_2.short_0;
    }

    public static bool smethod_2(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return !ObjectUID.smethod_1(objectUID_1, objectUID_2);
    }

    public static bool smethod_3(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return ObjectUID.smethod_0(objectUID_1, objectUID_2) < 0;
    }

    public static bool smethod_4(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return ObjectUID.smethod_0(objectUID_1, objectUID_2) > 0;
    }

    public static bool smethod_5(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return ObjectUID.smethod_0(objectUID_1, objectUID_2) <= 0;
    }

    public static bool smethod_6(ObjectUID objectUID_1, ObjectUID objectUID_2)
    {
        return ObjectUID.smethod_0(objectUID_1, objectUID_2) >= 0;
    }

    public static ObjectUID smethod_7(ObjectUID objectUID_1, short short_1)
    {
        short num = objectUID_1.short_0;
        num += short_1;
        return new ObjectUID(num);
    }

    public static ObjectUID smethod_8(ObjectUID objectUID_1)
    {
        short num = objectUID_1.short_0;
        num += 1;
        return new ObjectUID(num);
    }

    private readonly short short_0;

    public static readonly ObjectUID objectUID_0 = default(ObjectUID);
}
