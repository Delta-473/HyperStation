using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
//using Battle;
//using Cwave;
using ICSharpCode.SharpZipLib.GZip;
using ns4;
using HyperStation.GameServer.Network.Packet;
using HyperStation.GameServer.Network.Packet.GameServer;
using ProtoBuf;

namespace HyperStation.GameServer.Network
{
    public sealed class OutPacket : IDisposable
    {
        private Packet.Header header_0;
        private readonly MemoryStream memoryStream_0 = new MemoryStream();
        private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes(ConfigurationLoader.smethod_3("packetEncryptWord"));
        private static readonly MemoryStream memoryStream_1 = new MemoryStream();
        private static readonly byte[] byte_1 = new byte[4096];
        private static readonly byte[] byte_2 = new byte[8];

        [CompilerGenerated]
        private PacketType packetType_0;
        public PacketType _packetType { get; private set; }

        public Packet.Header method_0()
        {
            return this.header_0;
        }

        public void Dispose()
        {
            //GInstance._Instance._PacketPoolManager.ReleaseOutPacket(this);
            this.method_3();
        }

        public void method_1(OutPacket outPacket_0)
        {
            this.header_0 = outPacket_0.header_0;
            this._packetType = outPacket_0._packetType;
            ArraySegment<byte> arraySegment = outPacket_0.method_6();
            this.memoryStream_0.SetLength(0L);
            this.memoryStream_0.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
        }

        public void method_2(InPacket inPacket_0)
        {
            this.method_3();
            inPacket_0.method_7(out this.header_0, this.memoryStream_0);
        }

        public void method_3()
        {
            this.header_0 = Packet.Header.InvalidPacketID;
            this._packetType = PacketType.TEST;
            this.memoryStream_0.SetLength(0L);
        }

        public int method_4()
        {
            return (int)this.memoryStream_0.Position;
        }

        public void method_5(int int_0)
        {
            this.memoryStream_0.Position = (long)int_0;
        }

        public ArraySegment<byte> method_6()
        {
            return new ArraySegment<byte>(this.memoryStream_0.GetBuffer(), 0, (int)this.memoryStream_0.Length);
        }

        public long method_7()
        {
            return this.memoryStream_0.Length;
        }

        public void method_8(MemoryStream memoryStream_2)
        {
            this.memoryStream_0.Position = 0L;
            using (GZipOutputStream gzipOutputStream = new GZipOutputStream(memoryStream_2))
            {
                gzipOutputStream.IsStreamOwner = false;
                Array.Clear(OutPacket.byte_1, 0, OutPacket.byte_1.Length);
                int count;
                while ((count = this.memoryStream_0.Read(OutPacket.byte_1, 0, OutPacket.byte_1.Length)) > 0)
                {
                    gzipOutputStream.Write(OutPacket.byte_1, 0, count);
                }
            }
        }

        public byte[] method_9()
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                this.memoryStream_0.Position = 0L;
                using (GZipOutputStream gzipOutputStream = new GZipOutputStream(memoryStream))
                {
                    Array.Clear(OutPacket.byte_1, 0, OutPacket.byte_1.Length);
                    int count;
                    while ((count = this.memoryStream_0.Read(OutPacket.byte_1, 0, OutPacket.byte_1.Length)) > 0)
                    {
                        gzipOutputStream.Write(OutPacket.byte_1, 0, count);
                    }
                }
                result = memoryStream.ToArray();
            }
            return result;
        }

        private bool method_10(MemoryStream memoryStream_2)
        {
            if (this.method_14() && this.memoryStream_0.Length > 300L)
            {
                this.method_8(memoryStream_2);
                return true;
            }
            return false;
        }

        public void method_11(bool bool_0, MemoryStream memoryStream_2, bool bool_1)
        {
            OutPacket.memoryStream_1.SetLength(0L);
            bool flag;
            MemoryStream memoryStream = (!(flag = this.method_10(OutPacket.memoryStream_1))) ? this.memoryStream_0 : OutPacket.memoryStream_1;
            int num = (int)memoryStream.Length;
            int num2 = 4 + num;
            if (flag)
            {
                num2 *= -1;
            }
            ByteConverter.smethod_4(num2, OutPacket.byte_2);
            memoryStream_2.Write(OutPacket.byte_2, 0, 4);
            memoryStream_2.Write(memoryStream.GetBuffer(), 0, num);
            if (bool_0)
            {
                byte[] buffer = memoryStream_2.GetBuffer();
                for (int i = 0; i < num; i++)
                {
                    byte[] array = buffer;
                    int num3 = i + 4;
                    array[num3] ^= OutPacket.byte_0[i % OutPacket.byte_0.Length];
                }
            }
        }

        public int method_12()
        {
            return 4 + (int)this.method_7();
        }

        public bool method_13()
        {
            Packet.Header header = this.header_0;
            switch (header)
            {
                case Packet.Header.SCSP_Alive_UDP:
                case Packet.Header.SCSP_NetStressTest:
                    break;
                default:
                    switch (header)
                    {
                        case Packet.Header.SSCP_Alive_UDP:
                        case Packet.Header.SSCP_NetStressTest:
                            break;
                        default:
                            switch (header)
                            {
                                case Packet.Header.BCSP_ClientBattleCmd:
                                case Packet.Header.BCSP_ClientBattleCmdACK:
                                    break;
                                default:
                                    switch (header)
                                    {
                                        case Packet.Header.BSCP_ServerBattleCMDSingle:
                                        case Packet.Header.BSCP_ServerBattleCMDBunch:
                                            break;
                                        default:
                                            if (header != Packet.Header.LCSP_UDPConnect && header != Packet.Header.BSCP_UDPPacketSizeTest)
                                            {
                                                return true;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
            return false;
        }

        private bool method_14()
        {
            Packet.Header header = this.header_0;
            switch (header)
            {
                case Packet.Header.BSCP_ObserverStatistics:
                case Packet.Header.BSCP_ServerBattleCMDBunch:
                case Packet.Header.BSCP_ServerBattleCMDBunchTCP:
                    break;
                default:
                    if (header != Packet.Header.BSCP_WorldFullDataForReconnection && header != Packet.Header.BSCP_WorldFullDataForObserving && header != Packet.Header.BSCP_BattleFinished_Reconnect)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        public override string ToString()
        {
            return string.Format("Header[{0}] size[{1}]", this.header_0, this.memoryStream_0.Length);
        }

        public void method_15<T>(T gparam_0)
        {
            /*HyperStation.GameServer.Network.Header header = ClassSingleton<PacketManager>.Prop_0.GetHeader(gparam_0.GetType());
            this._packetType = header.packetType_0;
            this.memoryStream_0.Write(BitConverter.GetBytes((short)((byte)header.packetType_0)), 0, 1);
            this.memoryStream_0.Write(BitConverter.GetBytes((short)((byte)header.int_0)), 0, 1);
            Serializer.Serialize<T>(this.memoryStream_0, gparam_0);*/
        }

        public void method_16(Packet.Header header_1)
        {
            this.header_0 = header_1;
            this.method_18(header_1);
        }

        public void method_17(Packet.Header header_1)
        {
            if (this.header_0 == Packet.Header.InvalidPacketID)
            {
                this.method_16(header_1);
            }
            else if (this.header_0 != header_1)
            {
                long position = this.memoryStream_0.Position;
                this.memoryStream_0.Position = 0L;
                this.method_16(header_1);
                this.memoryStream_0.Position = position;
            }
        }

        public void method_18(Packet.Header header_1)
        {
            this.method_43((byte)header_1);
        }

        public void method_19(BattleCommandID battleCommandID_0)
        {
            this.method_43((byte)battleCommandID_0);
        }

        public void method_20(Team team_0)
        {
            this.method_54((sbyte)team_0);
        }

        public void method_21(ulong ulong_0)
        {
            this.method_50(ulong_0);
        }

        public void method_22(InputDir inputDir_0)
        {
            this.method_43((byte)inputDir_0);
        }

        public void method_23(SC_SkillHitResultDefine.MainDataFlag mainDataFlag_0)
        {
            this.method_43((byte)mainDataFlag_0);
        }

        public void method_24(SC_SkillHitResultDefine.SubDataFlag subDataFlag_0)
        {
            this.method_43((byte)subDataFlag_0);
        }

        public void method_25(SkillUseReason skillUseReason_0)
        {
            this.method_43((byte)skillUseReason_0);
        }

        public void method_26(SkillUnusableReason skillUnusableReason_0)
        {
            this.method_43((byte)skillUnusableReason_0);
        }

        public void method_27(Activate.Type type_0)
        {
            this.method_43((byte)type_0);
        }

        public void method_28(PawnType pawnType_0)
        {
            this.method_43((byte)pawnType_0);
        }

        public void method_29(PawnState.StateType stateType_0)
        {
            this.method_43((byte)stateType_0);
        }

        public void method_30(PawnSocialMotion pawnSocialMotion_0)
        {
            this.method_43((byte)pawnSocialMotion_0);
        }

        public void method_31(PawnEmotionEffect pawnEmotionEffect_0)
        {
            this.method_43((byte)pawnEmotionEffect_0);
        }

        public void method_32(Battle.Event event_0)
        {
            this.method_46((ushort)event_0);
        }

        public void method_33(SkillID skillID_0)
        {
            /*short short_ = NetworkConstTableClient.networkConstTableClient_0.method_11(skillID_0);
            this.method_45(short_);*/
        }

        public void method_34(SkillID skillID_0)
        {
            this.method_48(skillID_0.ToUInt32());
        }

        public void method_35(ItemID itemID_0)
        {
            this.method_48(itemID_0.method_0());
        }

        public void method_36(SkillResultID skillResultID_0)
        {
            this.method_33(skillResultID_0.skillID_0);
            this.method_55(skillResultID_0.int_0);
        }

        public void method_37(SkillBuffID skillBuffID_0)
        {
            this.method_36(skillBuffID_0.skillResultID_0);
            this.method_55(skillBuffID_0.int_0);
        }

        public void method_38(SkillOptionID skillOptionID_0)
        {
            this.method_48(skillOptionID_0.method_0());
        }

        public void method_39(PawnClassID pawnClassID_0)
        {
            this.method_48(pawnClassID_0.method_1());
        }

        public void method_40(PawnBodyID pawnBodyID_0)
        {
            this.method_48(pawnBodyID_0.method_1());
        }

        public void method_41(ObjectUID objectUID_0)
        {
            this.method_45(objectUID_0.method_0());
        }

        public void method_42(bool bool_0)
        {
            ByteConverter.smethod_0(bool_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 1);
        }

        public void method_43(byte byte_3)
        {
            OutPacket.byte_2[0] = byte_3;
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 1);
        }

        public void method_44(char char_0)
        {
            ByteConverter.smethod_1(char_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 2);
        }

        public void method_45(short short_0)
        {
            ByteConverter.smethod_2(short_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 2);
        }

        public void method_46(ushort ushort_0)
        {
            ByteConverter.smethod_3(ushort_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 2);
        }

        public void method_47(int int_0)
        {
            ByteConverter.smethod_4(int_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 4);
        }

        public void method_48(uint uint_0)
        {
            ByteConverter.smethod_5(uint_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 4);
        }

        public void method_49(long long_0)
        {
            ByteConverter.smethod_6(long_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 8);
        }

        public void method_50(ulong ulong_0)
        {
            ByteConverter.smethod_7(ulong_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 8);
        }

        public void method_51(float float_0)
        {
            ByteConverter.smethod_8(float_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 4);
        }

        public void method_52(double double_0)
        {
            ByteConverter.smethod_9(double_0, OutPacket.byte_2);
            this.memoryStream_0.Write(OutPacket.byte_2, 0, 8);
        }

        public void method_53(string string_0)
        {
            //Cwave.Util.StreamHelper.smethod_13(string_0, this.memoryStream_0);
        }

        public void method_54(sbyte sbyte_0)
        {
            this.method_43((byte)sbyte_0);
        }

        public void method_55(int int_0)
        {
            this.method_43((byte)int_0);
        }

        public void method_56(int int_0)
        {
            this.method_54((sbyte)int_0);
        }

        public void method_57(int int_0)
        {
            this.method_45((short)int_0);
        }

        public void method_58(int int_0)
        {
            this.method_46((ushort)int_0);
        }

        public void method_59<T>(T gparam_0)
        {
            TypeCode typeCode = Type.GetTypeCode(typeof(T));
            switch (typeCode)
            {
                case TypeCode.Byte:
                    this.method_43(Convert.ToByte(gparam_0));
                    break;
                case TypeCode.Int16:
                    this.method_45(Convert.ToInt16(gparam_0));
                    break;
                case TypeCode.UInt16:
                    this.method_46(Convert.ToUInt16(gparam_0));
                    break;
                case TypeCode.Int32:
                    this.method_47(Convert.ToInt32(gparam_0));
                    break;
                case TypeCode.UInt32:
                    this.method_48(Convert.ToUInt32(gparam_0));
                    break;
                default:
                    //GInstance.GLog.logFuncType_2(CwaveLog.String_0 + string.Format("type Error. code[{0}]", typeCode));
                    break;
            }
        }

        public void method_60(List<int> list_0)
        {
            if (list_0 != null)
            {
                this.method_47(list_0.Count);
                for (int i = 0; i < list_0.Count; i++)
                {
                    this.method_47(list_0[i]);
                }
            }
            else
            {
                this.method_47(0);
            }
        }

        public void method_61(List<int> list_0)
        {
            if (list_0 != null)
            {
                this.method_55(list_0.Count);
                for (int i = 0; i < list_0.Count; i++)
                {
                    this.method_47(list_0[i]);
                }
            }
            else
            {
                this.method_55(0);
            }
        }

        public void method_62(int[] int_0)
        {
            if (int_0 != null)
            {
                this.method_47(int_0.Length);
                for (int i = 0; i < int_0.Length; i++)
                {
                    this.method_47(int_0[i]);
                }
            }
            else
            {
                this.method_47(0);
            }
        }

        public void method_63(int[] int_0)
        {
            if (int_0 != null)
            {
                this.method_55(int_0.Length);
                for (int i = 0; i < int_0.Length; i++)
                {
                    this.method_47(int_0[i]);
                }
            }
            else
            {
                this.method_55(0);
            }
        }

        public void method_64(List<float> list_0)
        {
            if (list_0 != null)
            {
                this.method_47(list_0.Count);
                for (int i = 0; i < list_0.Count; i++)
                {
                    this.method_51(list_0[i]);
                }
            }
            else
            {
                this.method_47(0);
            }
        }

        public void method_65(List<float> list_0)
        {
            if (list_0 != null)
            {
                this.method_55(list_0.Count);
                for (int i = 0; i < list_0.Count; i++)
                {
                    this.method_51(list_0[i]);
                }
            }
            else
            {
                this.method_55(0);
            }
        }

        public void method_66<T>(T gparam_0) where T : IPacket
        {
            gparam_0.Encode(this);
        }

        public void method_67<T>(List<T> list_0) where T : IPacket
        {
            if (list_0 != null)
            {
                this.method_47(list_0.Count);
                for (int i = 0; i < list_0.Count; i++)
                {
                    this.method_66<T>(list_0[i]);
                }
            }
            else
            {
                this.method_47(0);
            }
        }

        public void method_68<T>(List<T> list_0) where T : IPacket
        {
            if (list_0 != null)
            {
                this.method_55(list_0.Count);
                for (int i = 0; i < list_0.Count; i++)
                {
                    this.method_66<T>(list_0[i]);
                }
            }
            else
            {
                this.method_55(0);
            }
        }

        public void method_69(Vector2 vector2_0)
        {
            this.method_51(vector2_0.x);
            this.method_51(vector2_0.y);
        }

        public void method_70(Vector3 vector3_0)
        {
            this.method_51(vector3_0.x);
            this.method_51(vector3_0.y);
            this.method_51(vector3_0.z);
        }

        public void method_71(byte[] byte_3, int int_0, int int_1)
        {
            this.memoryStream_0.Write(byte_3, int_0, int_1);
        }

        public void method_72(ArraySegment<byte> arraySegment_0)
        {
            this.memoryStream_0.Write(arraySegment_0.Array, arraySegment_0.Offset, arraySegment_0.Count);
        }
    }
}
