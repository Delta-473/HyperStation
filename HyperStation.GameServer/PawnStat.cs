using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using HyperStation.GameServer.Network;

public static class PawnStat
{
    public static PawnStat.IntFlag smethod_0(string string_2)
    {
        for (int i = 0; i < PawnStat.string_0.Length; i++)
        {
            if (PawnStat.string_0[i] == string_2)
            {
                return (PawnStat.IntFlag)i;
            }
        }
        return PawnStat.IntFlag.Max;
    }

    public static int smethod_1(PawnStat.IntFlag intFlag_1)
    {
        return PawnStat.int_0[(int)intFlag_1];
    }

    public static void smethod_2(PawnStat.IModDestElementaryStat imodDestElementaryStat_0, PawnStat.IModOperandElementaryStat imodOperandElementaryStat_0)
    {
        PawnStat.smethod_5(imodDestElementaryStat_0, imodOperandElementaryStat_0, false, 1);
    }

    public static void smethod_3(PawnStat.IModDestElementaryStat imodDestElementaryStat_0, PawnStat.IModOperandElementaryStat imodOperandElementaryStat_0)
    {
        PawnStat.smethod_5(imodDestElementaryStat_0, imodOperandElementaryStat_0, true, 1);
    }

    public static void smethod_4(PawnStat.IModDestElementaryStat imodDestElementaryStat_0, PawnStat.IModOperandElementaryStat imodOperandElementaryStat_0, int int_1)
    {
        PawnStat.smethod_5(imodDestElementaryStat_0, imodOperandElementaryStat_0, false, int_1);
    }

    private static void smethod_5(PawnStat.IModDestElementaryStat imodDestElementaryStat_0, PawnStat.IModOperandElementaryStat imodOperandElementaryStat_0, bool bool_0, int int_1)
    {
        if (imodDestElementaryStat_0 != null && imodOperandElementaryStat_0 != null)
        {
            int num = ((!bool_0) ? 1 : -1) * int_1;
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag flag = (PawnStat.IntFlag)i;
                if (imodOperandElementaryStat_0.HasValue(flag))
                {
                    int val = imodDestElementaryStat_0.GetValue(flag) + imodOperandElementaryStat_0.GetValue(flag) * num;
                    imodDestElementaryStat_0.SetValue(flag, val);
                }
            }
            return;
        }
    }

    public static void smethod_6(PawnStat.IElementaryStat ielementaryStat_0, List<string> list_0)
    {
        if (ielementaryStat_0 != null && list_0 != null)
        {
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag intFlag = (PawnStat.IntFlag)i;
                if (ielementaryStat_0.HasValue(intFlag))
                {
                    int value = ielementaryStat_0.GetValue(intFlag);
                    if (value != PawnStat.smethod_1(intFlag))
                    {
                        //string str = (!GameConstInfo.GameConstInfo_0.statInfo_0.lineParseHashSet_0.Contains((PawnStat.IntFlag)i)) ? string.Empty : GameConstInfo.GameConstInfo_0.statInfo_0.string_0;
                        //string item = GameTextManager.GameText("#" + PawnStat.string_0[i]) + " +" + value.ToString() + str;
                        //list_0.Add(item);
                    }
                }
            }
        }
    }

    public static bool smethod_7(PawnStat.MPType mptype_0, PawnStat.MPType mptype_1)
    {
        return mptype_1 != PawnStat.MPType.None && mptype_0 == mptype_1;
    }

    public static int smethod_8(PawnStat.MPType mptype_0, int int_1)
    {
        if (mptype_0 != PawnStat.MPType.TrueBlood)
        {
            return int_1;
        }
        return 0;
    }

    public static T smethod_9<T>(T gparam_0, PawnStat.MPType mptype_0, PawnStat.MPType mptype_1, bool bool_0) where T : PawnStat.IElementaryStat, new()
    {
        if (gparam_0 != null)
        {
            T t = (T)((object)null);
            if (!PawnStat.smethod_7(mptype_0, mptype_1))
            {
                for (int i = 0; i < PawnStat.intFlag_0.Length; i++)
                {
                    PawnStat.IntFlag intFlag = PawnStat.intFlag_0[i];
                    if (gparam_0.HasValue(intFlag))
                    {
                        if (t == null)
                        {
                            if (bool_0)
                            {
                                t = Activator.CreateInstance<T>();
                                t.CopyFromES(gparam_0);
                            }
                            else
                            {
                                t = gparam_0;
                            }
                        }
                        t.SetValue(intFlag, PawnStat.smethod_1(intFlag));
                    }
                }
                if (t != null)
                {
                    return t;
                }
            }
        }
        return gparam_0;
    }

    public static string smethod_10(PawnStat.MPType mptype_0)
    {
        if (mptype_0 == PawnStat.MPType.TrueBlood)
        {
            return "#MaxTrueBlood";
        }
        if (mptype_0 != PawnStat.MPType.Bullet)
        {
            return "#MaxMP";
        }
        return "#MaxBullet";
    }

    public static readonly string[] string_0 = new string[]
    {
        "PDam",
        "PDamR",
        "PArm",
        "PArmR",
        "MaxHP",
        "MaxHPR",
        "MaxMP",
        "MaxMPR",
        "HPReg",
        "MPReg",
        "HPRegP",
        "MPRegP",
        "HPRegR",
        "HPRecovReduceRatio",
        "MPRecovReduceRatio",
        "MoveSpd",
        "MoveSpdR",
        "AttSpdP",
        "Jump",
        "JumpR",
        "CriChanceP",
        "CriDamP",
        "PArmCut",
        "PArmPenP",
        "EvaP",
        "AccP",
        "CoolCut",
        "CoolRedP",
        "MPCut",
        "MPRedR",
        "DamCut",
        "DamRet",
        "PDamRefPToTDam",
        "HPSteal",
        "PDamAbsorbP",
        "TrueDam",
        "DamRedP",
        "DamAmplify",
        "DamAmplifyToEnemy",
        "SiegeDamP",
        "SiegeDamRedP",
        "Size"
    };

    public static readonly int[] int_0 = new int[42];

    public static readonly Dictionary<PawnStat.IntFlag, PawnStat.IntFlag> dictionary_0 = new Dictionary<PawnStat.IntFlag, PawnStat.IntFlag>(default(PawnStat.IntFlagComparer))
    {
        {
            PawnStat.IntFlag.PDam,
            PawnStat.IntFlag.PDamR
        },
        {
            PawnStat.IntFlag.PArm,
            PawnStat.IntFlag.PArmR
        },
        {
            PawnStat.IntFlag.MaxHP,
            PawnStat.IntFlag.MaxHPR
        },
        {
            PawnStat.IntFlag.MaxMP,
            PawnStat.IntFlag.MaxMPR
        },
        {
            PawnStat.IntFlag.MoveSpd,
            PawnStat.IntFlag.MoveSpdR
        },
        {
            PawnStat.IntFlag.Jump,
            PawnStat.IntFlag.JumpR
        },
        {
            PawnStat.IntFlag.MPCut,
            PawnStat.IntFlag.MPRedR
        },
        {
            PawnStat.IntFlag.HPReg,
            PawnStat.IntFlag.HPRegR
        }
    };

    public static readonly string[] string_1 = new string[]
    {
        "PDam",
        "PArm",
        "MaxHP",
        "MaxMP",
        "HPReg",
        "MPReg",
        "HPRegP",
        "MPRegP",
        "MoveSpd",
        "AttSpdP",
        "CriChanceP",
        "CriDamP",
        "EvaP",
        "AccP",
        "CoolCut",
        "CoolRedP",
        "MPCut",
        "MPRedR",
        "PArmCut",
        "PArmPenP",
        "DamCut",
        "DamRet",
        "DamRefP",
        "HPSteal",
        "PDamAbsorbP",
        "TrueDam",
        "DamRedP",
        "DamAmplify",
        "DamAmplifyToEnemy",
        "SiegeDamP",
        "SiegeDamRedP",
        "Max"
    };

    public static readonly PawnStat.IntFlag[] intFlag_0 = new PawnStat.IntFlag[]
    {
        PawnStat.IntFlag.MaxMP,
        PawnStat.IntFlag.MaxMPR,
        PawnStat.IntFlag.MPReg,
        PawnStat.IntFlag.MPRegP,
        PawnStat.IntFlag.MPCut,
        PawnStat.IntFlag.MPRedR
    };

    public enum IntFlag
    {
        PDam,
        PDamR,
        PArm,
        PArmR,
        MaxHP,
        MaxHPR,
        MaxMP,
        MaxMPR,
        HPReg,
        MPReg,
        HPRegP,
        MPRegP,
        HPRegR,
        HPRecovReduceRatio,
        MPRecovReduceRatio,
        MoveSpd,
        MoveSpdR,
        AttSpdP,
        Jump,
        JumpR,
        CriChanceP,
        CriDamP,
        PArmCut,
        PArmPenP,
        EvaP,
        AccP,
        CoolCut,
        CoolRedP,
        MPCut,
        MPRedR,
        DamCut,
        DamRet,
        PDamRefPToTDam,
        HPSteal,
        PDamAbsorbP,
        TrueDam,
        DamRedP,
        DamAmplify,
        DamAmplifyToEnemy,
        SiegeDamP,
        SiegeDamRedP,
        Size,
        Max
    }

    public struct IntFlagComparer : IEqualityComparer<PawnStat.IntFlag>
    {
        public bool Equals(PawnStat.IntFlag a, PawnStat.IntFlag b)
        {
            return a == b;
        }

        public int GetHashCode(PawnStat.IntFlag obj)
        {
            return (int)obj;
        }
    }

    public enum IntTotalFlag
    {
        PDam,
        PArm,
        MaxHP,
        MaxMP,
        HPReg,
        MPReg,
        HPRegP,
        MPRegP,
        MoveSpd,
        AttSpdP,
        CriChanceP,
        CriDamP,
        EvaP,
        AccP,
        CoolCut,
        CoolRedP,
        MPCut,
        MPRedR,
        PArmCut,
        PArmPenP,
        DamCut,
        DamRet,
        DamRefP,
        HPSteal,
        PDamAbsorbP,
        TrueDam,
        DamRedP,
        DamAmplify,
        DamAmplifyToEnemy,
        SiegeDamP,
        SiegeDamRedP,
        Max
    }

    public abstract class IElementaryStat : XmlClass, PawnStat.IModDestElementaryStat, PawnStat.IModOperandElementaryStat, IPacket
    {
        public IElementaryStat()
        {
        }

        public IElementaryStat(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public abstract int GetValue(PawnStat.IntFlag flag);

        public abstract void SetValue(PawnStat.IntFlag flag, int val);

        public virtual bool HasValue(PawnStat.IntFlag flag)
        {
            return true;
        }

        protected override void SetDefaultValue(string node, string totalPath, XmlNode topNode)
        {
            if (node == null)
            {
                this.ClearES();
            }
            else
            {
                this.ReadES(totalPath, topNode);
            }
        }

        protected abstract void ReadES(string totalPath, XmlNode topNode);

        public abstract void ClearES();

        protected bool ReadValue(XmlNode topNode, string totalPath, PawnStat.IntFlag flag)
        {
            string text = PawnStat.string_0[(int)flag];
            string childPath = (totalPath.Length != 0) ? (totalPath + "/" + text) : text;
            XmlNode xmlNode = base.NodeFind(topNode, childPath);
            if (xmlNode == null)
            {
                return false;
            }
            int val = Convert.ToInt32(xmlNode.InnerText);
            this.SetValue(flag, val);
            return true;
        }

        public abstract void CopyFromES(PawnStat.IElementaryStat other);

        public abstract bool NeedEncode(PawnStat.IntFlag flag);

        public void Encode(OutPacket oPacket)
        {
            PawnStat.FlagBits gparam_ = default(PawnStat.FlagBits);
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag intFlag = (PawnStat.IntFlag)i;
                if (this.NeedEncode(intFlag))
                {
                    gparam_.method_6(intFlag);
                }
            }
            oPacket.method_66<PawnStat.FlagBits>(gparam_);
            for (int j = 0; j < 42; j++)
            {
                PawnStat.IntFlag intFlag2 = (PawnStat.IntFlag)j;
                if (gparam_.method_8(intFlag2))
                {
                    oPacket.method_47(this.GetValue(intFlag2));
                }
            }
        }

        public void Decode(InPacket iPacket)
        {
            this.ClearES();
            PawnStat.FlagBits flagBits = iPacket.method_61<PawnStat.FlagBits>();
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag intFlag = (PawnStat.IntFlag)i;
                if (flagBits.method_8(intFlag))
                {
                    int val = iPacket.method_41();
                    this.SetValue(intFlag, val);
                }
            }
        }

        protected void EncodeES(out PawnStat.FlagBits bits, out List<int> intValues)
        {
            bits = default(PawnStat.FlagBits);
            intValues = null;
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag intFlag = (PawnStat.IntFlag)i;
                if (this.NeedEncode(intFlag))
                {
                    bits.method_6(intFlag);
                    if (intValues == null)
                    {
                        intValues = new List<int>();
                    }
                    intValues.Add(this.GetValue(intFlag));
                }
            }
        }

        protected void DecodeES(ref PawnStat.FlagBits bits, ref List<int> intValues)
        {
            this.ClearES();
            int num = 0;
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag intFlag = (PawnStat.IntFlag)i;
                if (bits.method_8(intFlag))
                {
                    this.SetValue(intFlag, intValues[num]);
                    num++;
                }
            }
        }

        public PawnStat.EncodedES SetToEncodedES()
        {
            PawnStat.EncodedES encodedES = new PawnStat.EncodedES();
            this.EncodeES(out encodedES.flagBits_0, out encodedES.list_0);
            return encodedES;
        }

        public void GetFromEncodedES(PawnStat.EncodedES encodedES)
        {
            if (encodedES == null)
            {
                this.ClearES();
            }
            else
            {
                this.DecodeES(ref encodedES.flagBits_0, ref encodedES.list_0);
            }
        }
    }

    public class ElementaryStat : PawnStat.IElementaryStat
    {
        public ElementaryStat()
        {
        }

        public ElementaryStat(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public override int GetValue(PawnStat.IntFlag flag)
        {
            return this.IntValue[(int)flag];
        }

        public override void SetValue(PawnStat.IntFlag flag, int val)
        {
            this.IntValue[(int)flag] = val;
        }

        protected override void ReadES(string totalPath, XmlNode topNode)
        {
            if (topNode != null)
            {
                for (int i = 0; i < 42; i++)
                {
                    PawnStat.IntFlag intFlag = (PawnStat.IntFlag)i;
                    if (!base.ReadValue(topNode, totalPath, intFlag))
                    {
                        this.SetValue(intFlag, PawnStat.smethod_1(intFlag));
                    }
                }
            }
        }

        public override void ClearES()
        {
            for (int i = 0; i < 42; i++)
            {
                this.IntValue[i] = PawnStat.smethod_1((PawnStat.IntFlag)i);
            }
        }

        public override void CopyFromES(PawnStat.IElementaryStat other)
        {
            if (other == null)
            {
                return;
            }
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag flag = (PawnStat.IntFlag)i;
                this.SetValue(flag, other.GetValue(flag));
            }
        }

        public override bool NeedEncode(PawnStat.IntFlag flag)
        {
            return this.GetValue(flag) != PawnStat.smethod_1(flag);
        }

        public int[] IntValue = new int[42];
    }

    public class ElementaryStatData : PawnStat.IElementaryStat
    {
        public ElementaryStatData()
        {
        }

        public ElementaryStatData(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public override int GetValue(PawnStat.IntFlag flag)
        {
            int num = 0;
            return (!this.IntValue.TryGetValue(flag, out num)) ? PawnStat.smethod_1(flag) : num;
        }

        public override void SetValue(PawnStat.IntFlag flag, int val)
        {
            this.IntValue[flag] = val;
        }

        public override bool HasValue(PawnStat.IntFlag flag)
        {
            return this.IntValue.ContainsKey(flag);
        }

        protected override void ReadES(string totalPath, XmlNode topNode)
        {
            if (topNode != null)
            {
                for (int i = 0; i < 42; i++)
                {
                    PawnStat.IntFlag flag = (PawnStat.IntFlag)i;
                    base.ReadValue(topNode, totalPath, flag);
                }
            }
        }

        public override void ClearES()
        {
            this.IntValue.Clear();
        }

        public override void CopyFromES(PawnStat.IElementaryStat other)
        {
            if (other == null)
            {
                return;
            }
            this.ClearES();
            for (int i = 0; i < 42; i++)
            {
                PawnStat.IntFlag flag = (PawnStat.IntFlag)i;
                if (other.HasValue(flag))
                {
                    this.SetValue(flag, other.GetValue(flag));
                }
            }
        }

        public override bool NeedEncode(PawnStat.IntFlag flag)
        {
            return this.HasValue(flag);
        }

        public Dictionary<PawnStat.IntFlag, int> IntValue = new Dictionary<PawnStat.IntFlag, int>(default(PawnStat.IntFlagComparer));
    }

    public class InitialStat : PawnStat.ElementaryStat
    {
        public InitialStat()
        {
        }

        public InitialStat(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public int CalcLevelStat(PawnStat.IntFlag statFlag, int level)
        {
            float num = 0f;
            switch (statFlag)
            {
                case PawnStat.IntFlag.PDam:
                    num = this.incPDam;
                    break;
                case PawnStat.IntFlag.PArm:
                    num = this.incPArm;
                    break;
                case PawnStat.IntFlag.MaxHP:
                    num = this.incMaxHP;
                    break;
                case PawnStat.IntFlag.MaxMP:
                    num = this.incMaxMP;
                    break;
                case PawnStat.IntFlag.HPReg:
                    num = this.incHPReg;
                    break;
                case PawnStat.IntFlag.MPReg:
                    num = this.incMPReg;
                    break;
            }
            float num2 = (float)this.GetValue(statFlag) + num * (float)(level - 1);
            return (int)num2;
        }

        public const string commonNode = "Common";

        [global::Xml("MaxLevel")]
        public int maxLevel = 1;

        [global::Xml("IncDam")]
        public float incPDam;

        [global::Xml("IncArm")]
        public float incPArm;

        [global::Xml("IncMaxHP")]
        public float incMaxHP;

        [global::Xml("IncMaxMP")]
        public float incMaxMP;

        [global::Xml("IncHPReg")]
        public float incHPReg;

        [global::Xml("IncMPReg")]
        public float incMPReg;
    }

    public interface ISecondaryStat
    {
        int imethod_0(PawnStat.IntFlag intFlag_0);
    }

    public interface IModDestElementaryStat
    {
        int GetValue(PawnStat.IntFlag flag);
        void SetValue(PawnStat.IntFlag flag, int val);
    }

    public interface IModOperandElementaryStat
    {
        int GetValue(PawnStat.IntFlag flag);
        bool HasValue(PawnStat.IntFlag flag);
    }

    public struct FlagBits : IPacket
    {
        public void Encode(OutPacket oPacket)
        {
            oPacket.method_48(this.uint_0);
            oPacket.method_48(this.uint_1);
        }

        public void Decode(InPacket iPacket)
        {
            this.uint_0 = iPacket.method_46();
            this.uint_1 = iPacket.method_46();
        }

        public int Int32_0
        {
            get
            {
                return 2;
            }
        }

        public int Int32_1
        {
            get
            {
                return this.Int32_0 * 32;
            }
        }

        private uint method_0(int int_2)
        {
            if (int_2 == 0)
            {
                return this.uint_0;
            }
            if (int_2 == 1)
            {
                return this.uint_1;
            }
            /*GInstance.GLog.logFuncType_0(string.Concat(new object[]
            {
                "[StatFlagBits] Invalid GetBit(). i:",
                int_2,
                ", count:",
                this.Int32_1
            }));*/
            return 0u;
        }

        private void method_1(int int_2, uint uint_2)
        {
            if (int_2 == 0)
            {
                this.uint_0 = uint_2;
            }
            else if (int_2 == 1)
            {
                this.uint_1 = uint_2;
            }
            else
            {
                /*GInstance.GLog.logFuncType_0(string.Concat(new object[]
                {
                    "[StatFlagBits] Invalid SetBit(). i:",
                    int_2,
                    ", count:",
                    this.Int32_1
                }));*/
            }
        }

        private bool this[int int_2]
        {
            get
            {
                return this.method_7(int_2);
            }
        }

        public void method_2()
        {
            for (int i = 0; i < this.Int32_0; i++)
            {
                this.method_1(i, 0u);
            }
        }

        private void method_3(int int_2)
        {
            if (!this.method_13(int_2))
            {
                return;
            }
            int int_3 = this.method_12(int_2);
            uint num = this.method_0(int_3);
            num &= ~(1u << int_2);
            this.method_1(int_3, num);
        }

        public void method_4(PawnStat.IntFlag intFlag_0)
        {
            this.method_3(PawnStat.FlagBits.smethod_0(intFlag_0));
        }

        private void method_5(int int_2)
        {
            if (!this.method_13(int_2))
            {
                return;
            }
            int int_3 = this.method_12(int_2);
            uint num = this.method_0(int_3);
            num |= 1u << int_2;
            this.method_1(int_3, num);
        }

        public void method_6(PawnStat.IntFlag intFlag_0)
        {
            this.method_5(PawnStat.FlagBits.smethod_0(intFlag_0));
        }

        private bool method_7(int int_2)
        {
            if (!this.method_13(int_2))
            {
                return false;
            }
            int int_3 = this.method_12(int_2);
            return ((ulong)this.method_0(int_3) & (ulong)(1L << (int_2 & 31 & 31))) != 0UL;
        }

        public bool method_8(PawnStat.IntFlag intFlag_0)
        {
            return this.method_7(PawnStat.FlagBits.smethod_0(intFlag_0));
        }

        public void method_9(PawnStat.FlagBits flagBits_0)
        {
            for (int i = 0; i < this.Int32_0; i++)
            {
                uint num = this.method_0(i);
                num &= flagBits_0.method_0(i);
                this.method_1(i, num);
            }
        }

        public void method_10(PawnStat.FlagBits flagBits_0)
        {
            for (int i = 0; i < this.Int32_0; i++)
            {
                uint num = this.method_0(i);
                num |= flagBits_0.method_0(i);
                this.method_1(i, num);
            }
        }

        public override int GetHashCode()
        {
            int num = 1234;
            for (int i = 0; i < this.Int32_0; i++)
            {
                num ^= (int)(this.method_0(i) * (uint)(i + 1));
            }
            return num ^ num;
        }

        public bool method_11(PawnStat.FlagBits flagBits_0)
        {
            for (int i = 0; i < this.Int32_0; i++)
            {
                uint num = this.method_0(i);
                uint num2 = flagBits_0.method_0(i);
                if (num != num2)
                {
                    return false;
                }
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is PawnStat.FlagBits && this.method_11((PawnStat.FlagBits)obj);
        }

        private int method_12(int int_2)
        {
            return int_2 >> 5;
        }

        private bool method_13(int int_2)
        {
            int num = this.method_12(int_2);
            if (int_2 < this.Int32_1 && num < this.Int32_0)
            {
                return true;
            }
            /*GInstance.GLog.logFuncType_0(string.Concat(new object[]
            {
                "[StatFlagBits] Invalid CheckFlagIndex. index:",
                int_2,
                ", count:",
                this.Int32_1,
                ", nBitSlot:",
                num,
                ", BitSlotCount:",
                this.Int32_0
            }));*/
            return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.Int32_1; i++)
            {
                if (i % 32 == 0 && this.method_12(i) != 0)
                {
                    stringBuilder.Append(" ");
                }
                stringBuilder.Append((!this.method_7(i)) ? "0" : "1");
            }
            return stringBuilder.ToString();
        }

        public static int smethod_0(PawnStat.IntFlag intFlag_0)
        {
            return (int)intFlag_0;
        }

        private static int smethod_1(uint uint_2)
        {
            int num = 0;
            while (uint_2 != 0u)
            {
                num++;
                uint_2 &= uint_2 - 1u;
            }
            return num;
        }

        public int method_14()
        {
            int num = 0;
            for (int i = 0; i < this.Int32_0; i++)
            {
                uint uint_ = this.method_0(i);
                num += PawnStat.FlagBits.smethod_1(uint_);
            }
            return num;
        }

        public static bool smethod_2(PawnStat.FlagBits flagBits_0, PawnStat.FlagBits flagBits_1)
        {
            return flagBits_0.method_11(flagBits_1);
        }

        public static bool smethod_3(PawnStat.FlagBits flagBits_0, PawnStat.FlagBits flagBits_1)
        {
            return !PawnStat.FlagBits.smethod_2(flagBits_0, flagBits_1);
        }

        public const int int_0 = 5;
        public const int int_1 = 31;
        public uint uint_0;
        public uint uint_1;
    }

    public class EncodedES : IPacket
    {
        public void Encode(OutPacket oPacket)
        {
            oPacket.method_66<PawnStat.FlagBits>(this.flagBits_0);
            int num = this.flagBits_0.method_14();
            for (int i = 0; i < num; i++)
            {
                oPacket.method_47(this.list_0[i]);
            }
        }

        public void Decode(InPacket iPacket)
        {
            this.flagBits_0 = iPacket.method_61<PawnStat.FlagBits>();
            int num = this.flagBits_0.method_14();
            if (num > 0)
            {
                this.list_0 = new List<int>();
            }
            for (int i = 0; i < num; i++)
            {
                int item = iPacket.method_41();
                this.list_0.Add(item);
            }
        }

        public PawnStat.FlagBits flagBits_0;

        public List<int> list_0;
    }

    public static class GameTextID
    {
        public const string string_0 = "#MaxMP";
        public const string string_1 = "#MaxTrueBlood";
        public const string string_2 = "#MaxBullet";
    }

    public enum MPType : byte
    {
        Mana,
        None,
        TrueBlood,
        Bullet
    }
}
