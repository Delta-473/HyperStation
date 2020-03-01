using System;
using HyperStation.GameServer.Network;

public struct MapID : IEquatable<MapID>, IPacket
{
    public MapID(string string_0)
    {
        this.uint_0 = Convert.ToUInt32(string_0);
    }

    public MapID(uint uint_1)
    {
        this.uint_0 = uint_1;
    }

    public void Encode(OutPacket oPacket)
    {
        oPacket.method_48(this.uint_0);
    }

    public void Decode(InPacket iPacket)
    {
        this.uint_0 = iPacket.method_46();
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

    public bool Equals(MapID other)
    {
        return MapID.smethod_0(this, other);
    }

    public override bool Equals(object obj)
    {
        return obj is MapID && MapID.smethod_0(this, (MapID)obj);
    }

    public static bool smethod_0(MapID mapID_1, MapID mapID_2)
    {
        return mapID_1.uint_0 == mapID_2.uint_0;
    }

    public static bool smethod_1(MapID mapID_1, MapID mapID_2)
    {
        return !MapID.smethod_0(mapID_1, mapID_2);
    }

    private uint uint_0;

    public static readonly MapID mapID_0 = default(MapID);
}
