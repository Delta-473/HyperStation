using System;

[Serializable]
public struct PawnBodyID : IComparable<PawnBodyID>, IEquatable<PawnBodyID>
{
    public PawnBodyID(string string_0)
    {
        this._value = Convert.ToUInt32(string_0);
    }

    public PawnBodyID(uint uint_0)
    {
        this._value = uint_0;
    }

    public bool method_0()
    {
        return this._value != PawnBodyID.pawnBodyID_0.method_1() && this._value != PawnBodyID.pawnBodyID_1.method_1();
    }

    public override string ToString()
    {
        return this._value.ToString();
    }

    public uint method_1()
    {
        return this._value;
    }

    public override int GetHashCode()
    {
        return this._value.GetHashCode();
    }

    public bool Equals(PawnBodyID other)
    {
        return PawnBodyID.smethod_0(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is PawnBodyID && PawnBodyID.smethod_0(this, (PawnBodyID)obj);
    }

    public int CompareTo(PawnBodyID other)
    {
        if (this._value < other._value)
        {
            return -1;
        }
        if (this._value > other._value)
        {
            return 1;
        }
        return 0;
    }

    public static bool smethod_0(PawnBodyID pawnBodyID_3, PawnBodyID pawnBodyID_4)
    {
        return pawnBodyID_3._value == pawnBodyID_4._value;
    }

    public static bool smethod_1(PawnBodyID pawnBodyID_3, PawnBodyID pawnBodyID_4)
    {
        return !PawnBodyID.smethod_0(pawnBodyID_3, pawnBodyID_4);
    }

    private readonly uint _value;

    public static readonly PawnBodyID pawnBodyID_0 = default(PawnBodyID);

    public static readonly PawnBodyID pawnBodyID_1 = new PawnBodyID(6456541u);

    public static readonly PawnBodyID pawnBodyID_2 = new PawnBodyID(6456542u);
}
