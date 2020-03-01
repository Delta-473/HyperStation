using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HyperStation.GameServer
{
    public static class ByteConverter
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct _ConvertData
        {
            [FieldOffset(0)]
            public bool bool_0;
            [FieldOffset(0)]
            public char char_0;
            [FieldOffset(0)]
            public short short_0;
            [FieldOffset(0)]
            public ushort ushort_0;
            [FieldOffset(0)]
            public int int_0;
            [FieldOffset(0)]
            public uint uint_0;
            [FieldOffset(0)]
            public long long_0;
            [FieldOffset(0)]
            public ulong ulong_0;
            [FieldOffset(0)]
            public float float_0;
            [FieldOffset(0)]
            public double double_0;
            [FieldOffset(0)]
            public byte byte_0;
            [FieldOffset(1)]
            public byte byte_1;
            [FieldOffset(2)]
            public byte byte_2;
            [FieldOffset(3)]
            public byte byte_3;
            [FieldOffset(4)]
            public byte byte_4;
            [FieldOffset(5)]
            public byte byte_5;
            [FieldOffset(6)]
            public byte byte_6;
            [FieldOffset(7)]
            public byte byte_7;
        }

        public static void smethod_0(bool bool_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.bool_0 = bool_0;
            byte_0[0] = convertData.byte_0;
        }

        public static void smethod_1(char char_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.char_0 = char_0;
            byte_0[0] = convertData.byte_0;
        }

        public static void smethod_2(short short_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.short_0 = short_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
        }

        public static void smethod_3(ushort ushort_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.ushort_0 = ushort_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
        }

        public static void smethod_4(int int_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.int_0 = int_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
            byte_0[2] = convertData.byte_2;
            byte_0[3] = convertData.byte_3;
        }

        public static void smethod_5(uint uint_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.uint_0 = uint_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
            byte_0[2] = convertData.byte_2;
            byte_0[3] = convertData.byte_3;
        }

        public static void smethod_6(long long_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.long_0 = long_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
            byte_0[2] = convertData.byte_2;
            byte_0[3] = convertData.byte_3;
            byte_0[4] = convertData.byte_4;
            byte_0[5] = convertData.byte_5;
            byte_0[6] = convertData.byte_6;
            byte_0[7] = convertData.byte_7;
        }

        public static void smethod_7(ulong ulong_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.ulong_0 = ulong_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
            byte_0[2] = convertData.byte_2;
            byte_0[3] = convertData.byte_3;
            byte_0[4] = convertData.byte_4;
            byte_0[5] = convertData.byte_5;
            byte_0[6] = convertData.byte_6;
            byte_0[7] = convertData.byte_7;
        }

        public static void smethod_8(float float_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.float_0 = float_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
            byte_0[2] = convertData.byte_2;
            byte_0[3] = convertData.byte_3;
        }

        public static void smethod_9(double double_0, byte[] byte_0)
        {
            ByteConverter._ConvertData convertData = default(ByteConverter._ConvertData);
            convertData.double_0 = double_0;
            byte_0[0] = convertData.byte_0;
            byte_0[1] = convertData.byte_1;
            byte_0[2] = convertData.byte_2;
            byte_0[3] = convertData.byte_3;
            byte_0[4] = convertData.byte_4;
            byte_0[5] = convertData.byte_5;
            byte_0[6] = convertData.byte_6;
            byte_0[7] = convertData.byte_7;
        }
    }
}
