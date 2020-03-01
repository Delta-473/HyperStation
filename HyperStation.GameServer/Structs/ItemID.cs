using System;

namespace HyperStation.GameServer
{
    public struct ItemID : IComparable<ItemID>, IEquatable<ItemID>
    {
        public ItemID(string string_0)
        {
            this.uint_0 = Convert.ToUInt32(string_0);
        }

        public ItemID(uint uint_1)
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

        public bool Equals(ItemID other)
        {
            return ItemID.smethod_0(this, other);
        }

        public override bool Equals(object obj)
        {
            return obj is ItemID && ItemID.smethod_0(this, (ItemID)obj);
        }

        public int CompareTo(ItemID other)
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

        public static bool smethod_0(ItemID itemID_1, ItemID itemID_2)
        {
            return itemID_1.uint_0 == itemID_2.uint_0;
        }

        public static bool smethod_1(ItemID itemID_1, ItemID itemID_2)
        {
            return !ItemID.smethod_0(itemID_1, itemID_2);
        }

        private readonly uint uint_0;

        public static readonly ItemID itemID_0 = default(ItemID);
    }

}
