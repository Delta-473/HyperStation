using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

[TypeConverter(typeof(SkillIDConverter))]
public struct SkillID : IComparable<SkillID>, IEquatable<SkillID>, IXmlSerializable
{
    public SkillID(string value_)
    {
        this._value = Convert.ToUInt32(value_);
    }

    public SkillID(uint value_)
    {
        this._value = value_;
    }

    public override string ToString()
    {
        return this._value.ToString();
    }

    public uint ToUInt32()
    {
        return this._value;
    }

    public override int GetHashCode()
    {
        return this._value.GetHashCode();
    }

    public bool Equals(SkillID other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        return obj is SkillID && this == (SkillID)obj;
    }

    public int CompareTo(SkillID other)
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

    public XmlSchema GetSchema()
    {
        return null;
    }

    public void ReadXml(XmlReader reader)
    {
        this._value = Convert.ToUInt32(reader.ReadString());
        reader.Read();
    }

    public void WriteXml(XmlWriter writer)
    {
        writer.WriteString(this._value.ToString());
    }

    public static bool operator ==(SkillID a, SkillID b)
    {
        return a._value == b._value;
    }

    public static bool operator !=(SkillID a, SkillID b)
    {
        return !(a == b);
    }

    private uint _value;

    public static readonly SkillID _INVALID_ID = default(SkillID);
}
