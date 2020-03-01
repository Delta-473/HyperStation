using System;

[Serializable]
public struct PawnClassID : IComparable<PawnClassID>, IEquatable<PawnClassID>
{
    public PawnClassID(string string_0)
    {
        this._value = Convert.ToUInt32(string_0);
    }

    public PawnClassID(uint uint_0)
    {
        this._value = uint_0;
    }

    public bool method_0()
    {
        return this._value != PawnClassID.pawnClassID_0.method_1() && this._value != PawnClassID.pawnClassID_1.method_1();
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

    public bool Equals(PawnClassID other)
    {
        return PawnClassID.smethod_0(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is PawnClassID && PawnClassID.smethod_0(this, (PawnClassID)obj);
    }

    public int CompareTo(PawnClassID other)
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

    public static bool smethod_0(PawnClassID pawnClassID_3, PawnClassID pawnClassID_4)
    {
        return pawnClassID_3._value == pawnClassID_4._value;
    }

    public static bool smethod_1(PawnClassID pawnClassID_3, PawnClassID pawnClassID_4)
    {
        return !PawnClassID.smethod_0(pawnClassID_3, pawnClassID_4);
    }

    private readonly uint _value;

    public static readonly PawnClassID pawnClassID_0 = default(PawnClassID);

    public static readonly PawnClassID pawnClassID_1 = new PawnClassID(6456541u);

    public static readonly PawnClassID pawnClassID_2 = new PawnClassID(6456542u);
}
