using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using HyperStation.GameServer.Network.Packet.Battle;
//using Cwave;
using ICSharpCode.SharpZipLib.GZip;
using ns4;
using HyperStation.GameServer.Network.Packet;
using HyperStation.GameServer.Network.Packet.GameServer;
using HyperStation.GameServer.Network;
using ProtoBuf;

namespace HyperStation.GameServer.Network
{
    public sealed class InPacket : IDisposable
    {
        private MemoryStream memoryStream_0;
        private static byte[] byte_0;
        private static byte[] byte_1;
        private HyperStation.GameServer.Network.Header header_0 = new HyperStation.GameServer.Network.Header();
        private static byte[] byte_2 = new byte[8];


        static InPacket()
        {
            //InPacket.byte_0 = Encoding.ASCII.GetBytes(ConfigurationLoader.smethod_3("packetEncryptWord"));
            InPacket.byte_1 = new byte[4096];
        }

        public byte[] method_0()
        {
            return this.memoryStream_0.GetBuffer();
        }

        public void method_1(byte[] byte_3, int int_0, int int_1, bool bool_0, bool bool_1)
        {
            if (bool_0)
            {
                for (int i = 0; i < int_1; i++)
                {
                    int num = int_0 + i;
                    byte_3[num] ^= InPacket.byte_0[i % InPacket.byte_0.Length];
                }
            }
            if (bool_1)
            {
                using (MemoryStream memoryStream = new MemoryStream(byte_3, int_0, int_1, false, true))
                {
                    this.memoryStream_0 = new MemoryStream();
                    using (GZipInputStream gzipInputStream = new GZipInputStream(memoryStream))
                    {
                        Array.Clear(InPacket.byte_1, 0, InPacket.byte_1.Length);
                        int count;
                        while ((count = gzipInputStream.Read(InPacket.byte_1, 0, InPacket.byte_1.Length)) > 0)
                        {
                            this.memoryStream_0.Write(InPacket.byte_1, 0, count);
                        }
                    }
                    this.memoryStream_0.Position = 0L;
                    return;
                }
            }
            this.memoryStream_0 = new MemoryStream(byte_3, int_0, int_1, false, true);
        }

        public void Dispose()
        {
            //GInstance._Instance._PacketPoolManager.ReleaseInPacket(this);
            this.memoryStream_0.Dispose();
            this.memoryStream_0 = null;
        }

        public void method_2()
        {
            this.memoryStream_0.Seek(0L, SeekOrigin.Begin);
        }

        public void method_3()
        {
            this.memoryStream_0.Seek(0L, SeekOrigin.Begin);
            this.memoryStream_0.SetLength(0L);
        }

        public long method_4()
        {
            return this.memoryStream_0.Length;
        }

        public int method_5()
        {
            return (int)this.memoryStream_0.Position;
        }

        public void method_6(int int_0)
        {
            this.memoryStream_0.Position = (long)int_0;
        }

        public void method_7(out Packet.Header header_1, MemoryStream memoryStream_1)
        {
            memoryStream_1.SetLength(0L);
            byte[] buffer = this.memoryStream_0.GetBuffer();
            int count = (int)this.memoryStream_0.Length;
            memoryStream_1.Write(buffer, 0, count);
            int int_ = this.method_5();
            this.method_6(0);
            header_1 = this.method_11();
            this.method_6(int_);
        }

        public HyperStation.GameServer.Network.Header method_8()
        {
            this.memoryStream_0.Position = 0L;
            this.header_0.packetType_0 = (PacketType)this.memoryStream_0.ReadByte();
            this.header_0.int_0 = this.memoryStream_0.ReadByte();
            this.memoryStream_0.Position = 0L;
            return this.header_0;
        }

        public T method_9<T>()
        {
            this.memoryStream_0.Position = 2L;
            return Serializer.Deserialize<T>(this.memoryStream_0);
        }

        public Packet.Header method_10()
        {
            return this.method_11();
        }

        public Packet.Header method_11()
        {
            return (Packet.Header)this.method_36();
        }

        public BattleCommandID method_12()
        {
            return (BattleCommandID)this.method_36();
        }

        public Team method_13()
        {
            return (Team)this.method_37();
        }

        public ulong method_14()
        {
            return this.method_48();
        }

        public InputDir method_15()
        {
            return (InputDir)this.method_36();
        }

        public SC_SkillHitResultDefine.MainDataFlag method_16()
        {
            return (SC_SkillHitResultDefine.MainDataFlag)this.method_36();
        }

        public SC_SkillHitResultDefine.SubDataFlag method_17()
        {
            return (SC_SkillHitResultDefine.SubDataFlag)this.method_36();
        }

        public SkillUseReason method_18()
        {
            return (SkillUseReason)this.method_36();
        }

        public SkillUnusableReason method_19()
        {
            return (SkillUnusableReason)this.method_36();
        }

        public Activate.Type method_20()
        {
            return (Activate.Type)this.method_36();
        }

        public PawnType method_21()
        {
            return (PawnType)this.method_36();
        }

        public PawnState.StateType method_22()
        {
            return (PawnState.StateType)this.method_36();
        }

        public PawnSocialMotion method_23()
        {
            return (PawnSocialMotion)this.method_36();
        }

        public PawnEmotionEffect method_24()
        {
            return (PawnEmotionEffect)this.method_36();
        }

        public Battle.Event method_25()
        {
            return (Battle.Event)this.method_40();
        }

        public SkillID method_26()
        {
            short short_ = this.method_39();
            return NetworkConstTableClient.networkConstTableClient_0.method_10(short_);
        }

        public SkillID method_27()
        {
            uint value_ = this.method_46();
            return new SkillID(value_);
        }

        public ItemID method_28()
        {
            uint uint_ = this.method_46();
            return new ItemID(uint_);
        }

        public SkillResultID method_29()
        {
            SkillID skillID_ = this.method_26();
            int int_ = this.method_42();
            return new SkillResultID(skillID_, int_);
        }

        public SkillBuffID method_30()
        {
            SkillResultID skillResultID_ = this.method_29();
            int int_ = this.method_42();
            return new SkillBuffID(skillResultID_, int_);
        }

        public SkillOptionID method_31()
        {
            uint uint_ = this.method_46();
            return new SkillOptionID(uint_);
        }

        public PawnClassID method_32()
        {
            uint uint_ = this.method_46();
            return new PawnClassID(uint_);
        }

        public PawnBodyID method_33()
        {
            uint uint_ = this.method_46();
            return new PawnBodyID(uint_);
        }

        public ObjectUID method_34()
        {
            short short_ = this.method_39();
            return new ObjectUID(short_);
        }

        public bool method_35()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 1);
            return BitConverter.ToBoolean(InPacket.byte_2, 0);
        }

        public byte method_36()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 1);
            return InPacket.byte_2[0];
        }

        public sbyte method_37()
        {
            return (sbyte)this.method_36();
        }

        public char method_38()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 2);
            return BitConverter.ToChar(InPacket.byte_2, 0);
        }

        public short method_39()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 2);
            return BitConverter.ToInt16(InPacket.byte_2, 0);
        }

        public ushort method_40()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 2);
            return BitConverter.ToUInt16(InPacket.byte_2, 0);
        }

        public int method_41()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 4);
            return BitConverter.ToInt32(InPacket.byte_2, 0);
        }

        public int method_42()
        {
            return (int)this.method_36();
        }

        public int method_43()
        {
            return (int)this.method_37();
        }

        public int method_44()
        {
            return (int)this.method_39();
        }

        public int method_45()
        {
            return (int)this.method_40();
        }

        public uint method_46()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 4);
            return BitConverter.ToUInt32(InPacket.byte_2, 0);
        }

        public long method_47()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 8);
            return BitConverter.ToInt64(InPacket.byte_2, 0);
        }

        public ulong method_48()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 8);
            return BitConverter.ToUInt64(InPacket.byte_2, 0);
        }

        public float method_49()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 4);
            return BitConverter.ToSingle(InPacket.byte_2, 0);
        }

        public double method_50()
        {
            this.memoryStream_0.Read(InPacket.byte_2, 0, 8);
            return BitConverter.ToDouble(InPacket.byte_2, 0);
        }

        public string method_51()
        {
            return "";  //Cwave.Util.StreamHelper.smethod_14(this.memoryStream_0);
        }

        public byte[] method_52(int int_0)
        {
            byte[] array = new byte[int_0];
            this.memoryStream_0.Read(array, 0, int_0);
            return array;
        }

        public void method_53(byte[] byte_3, int int_0)
        {
            this.memoryStream_0.Read(byte_3, 0, int_0);
        }

        public T method_54<T>()
        {
            object obj = null;
            TypeCode typeCode = Type.GetTypeCode(typeof(T));
            switch (typeCode)
            {
                case TypeCode.Byte:
                    obj = this.method_36();
                    break;
                case TypeCode.Int16:
                    obj = this.method_39();
                    break;
                case TypeCode.UInt16:
                    obj = this.method_40();
                    break;
                case TypeCode.Int32:
                    obj = this.method_41();
                    break;
                case TypeCode.UInt32:
                    obj = this.method_46();
                    break;
                default:
                    //GInstance.GLog.logFuncType_2(CwaveLog.String_0 + string.Format("type Error. code[{0}]", typeCode));
                    break;
            }
            return (T)((object)obj);
        }

        public List<int> method_55()
        {
            List<int> list = null;
            int num = this.method_41();
            if (num > 0)
            {
                list = new List<int>();
                for (int i = 0; i < num; i++)
                {
                    int item = this.method_41();
                    list.Add(item);
                }
            }
            return list;
        }

        public List<int> method_56()
        {
            List<int> list = null;
            int num = this.method_42();
            if (num > 0)
            {
                list = new List<int>();
                for (int i = 0; i < num; i++)
                {
                    int item = this.method_41();
                    list.Add(item);
                }
            }
            return list;
        }

        public int[] method_57()
        {
            int[] array = null;
            int num = this.method_41();
            if (num > 0)
            {
                array = new int[num];
                for (int i = 0; i < num; i++)
                {
                    array[i] = this.method_41();
                }
            }
            return array;
        }

        public int[] method_58()
        {
            int[] array = null;
            int num = this.method_42();
            if (num > 0)
            {
                array = new int[num];
                for (int i = 0; i < num; i++)
                {
                    array[i] = this.method_41();
                }
            }
            return array;
        }

        public List<float> method_59()
        {
            List<float> list = null;
            int num = this.method_41();
            if (num > 0)
            {
                list = new List<float>();
                for (int i = 0; i < num; i++)
                {
                    float item = this.method_49();
                    list.Add(item);
                }
            }
            return list;
        }

        public List<float> method_60()
        {
            List<float> list = null;
            int num = this.method_42();
            if (num > 0)
            {
                list = new List<float>();
                for (int i = 0; i < num; i++)
                {
                    float item = this.method_49();
                    list.Add(item);
                }
            }
            return list;
        }

        public T method_61<T>() where T : IPacket, new()
        {
            T result = (default(T) == null) ? Activator.CreateInstance<T>() : default(T);
            result.Decode(this);
            return result;
        }

        public List<T> method_62<T>() where T : IPacket, new()
        {
            List<T> list = null;
            int num = this.method_41();
            if (num > 0)
            {
                list = new List<T>();
                for (int i = 0; i < num; i++)
                {
                    T item = this.method_61<T>();
                    list.Add(item);
                }
            }
            return list;
        }

        public List<T> method_63<T>() where T : IPacket, new()
        {
            List<T> list = null;
            int num = this.method_42();
            if (num > 0)
            {
                list = new List<T>();
                for (int i = 0; i < num; i++)
                {
                    T item = this.method_61<T>();
                    list.Add(item);
                }
            }
            return list;
        }

        public Vector2 method_64()
        {
            return new Vector2
            {
                x = this.method_49(),
                y = this.method_49()
            };
        }

        public Vector3 method_65()
        {
            return new Vector3
            {
                x = this.method_49(),
                y = this.method_49(),
                z = this.method_49()
            };
        }

       
    }

}
