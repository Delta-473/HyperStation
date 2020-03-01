using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperStation.GameServer
{
    public static class Mathf
    {
        public static float smethod_0(float float_6)
        {
            return (float)Math.Sin((double)float_6);
        }

        public static float smethod_1(float float_6)
        {
            return (float)Math.Cos((double)float_6);
        }

        public static float smethod_2(float float_6)
        {
            return (float)Math.Tan((double)float_6);
        }

        public static float smethod_3(float float_6)
        {
            return (float)Math.Asin((double)float_6);
        }

        public static float smethod_4(float float_6)
        {
            return (float)Math.Acos((double)float_6);
        }

        public static float smethod_5(float float_6)
        {
            return (float)Math.Atan((double)float_6);
        }

        public static float smethod_6(float float_6, float float_7)
        {
            return (float)Math.Atan2((double)float_6, (double)float_7);
        }

        public static float smethod_7(float float_6)
        {
            return (float)Math.Sqrt((double)float_6);
        }

        public static float smethod_8(float float_6)
        {
            return Math.Abs(float_6);
        }

        public static int smethod_9(int int_0)
        {
            return Math.Abs(int_0);
        }

        public static float smethod_10(float float_6, float float_7)
        {
            return (float_6 < float_7) ? float_6 : float_7;
        }

        public static float smethod_11(params float[] float_6)
        {
            int num = float_6.Length;
            if (num == 0)
            {
                return 0f;
            }
            float num2 = float_6[0];
            for (int i = 1; i < num; i++)
            {
                if (float_6[i] < num2)
                {
                    num2 = float_6[i];
                }
            }
            return num2;
        }

        public static int smethod_12(int int_0, int int_1)
        {
            return (int_0 < int_1) ? int_0 : int_1;
        }

        public static int smethod_13(params int[] int_0)
        {
            int num = int_0.Length;
            if (num == 0)
            {
                return 0;
            }
            int num2 = int_0[0];
            for (int i = 1; i < num; i++)
            {
                if (int_0[i] < num2)
                {
                    num2 = int_0[i];
                }
            }
            return num2;
        }

        public static float smethod_14(float float_6, float float_7)
        {
            return (float_6 > float_7) ? float_6 : float_7;
        }

        public static float smethod_15(params float[] float_6)
        {
            int num = float_6.Length;
            if (num == 0)
            {
                return 0f;
            }
            float num2 = float_6[0];
            for (int i = 1; i < num; i++)
            {
                if (float_6[i] > num2)
                {
                    num2 = float_6[i];
                }
            }
            return num2;
        }

        public static int smethod_16(int int_0, int int_1)
        {
            return (int_0 > int_1) ? int_0 : int_1;
        }

        public static int smethod_17(params int[] int_0)
        {
            int num = int_0.Length;
            if (num == 0)
            {
                return 0;
            }
            int num2 = int_0[0];
            for (int i = 1; i < num; i++)
            {
                if (int_0[i] > num2)
                {
                    num2 = int_0[i];
                }
            }
            return num2;
        }

        public static float smethod_18(float float_6, float float_7)
        {
            return (float)Math.Pow((double)float_6, (double)float_7);
        }

        public static float smethod_19(float float_6)
        {
            return (float)Math.Exp((double)float_6);
        }

        public static float smethod_20(float float_6, float float_7)
        {
            return (float)Math.Log((double)float_6, (double)float_7);
        }

        public static float smethod_21(float float_6)
        {
            return (float)Math.Log((double)float_6);
        }

        public static float smethod_22(float float_6)
        {
            return (float)Math.Log10((double)float_6);
        }

        public static float smethod_23(float float_6)
        {
            return (float)Math.Ceiling((double)float_6);
        }

        public static float smethod_24(float float_6)
        {
            return (float)Math.Floor((double)float_6);
        }

        public static float smethod_25(float float_6)
        {
            return (float)Math.Round((double)float_6);
        }

        public static int smethod_26(float float_6)
        {
            return (int)Math.Ceiling((double)float_6);
        }

        public static int smethod_27(double double_0)
        {
            return (int)Math.Ceiling(double_0);
        }

        public static int smethod_28(float float_6)
        {
            return (int)Math.Floor((double)float_6);
        }

        public static int smethod_29(float float_6)
        {
            return (int)Math.Round((double)float_6);
        }

        public static float smethod_30(float float_6)
        {
            return (float_6 >= 0f) ? 1f : -1f;
        }

        public static float smethod_31(float float_6, float float_7, float float_8)
        {
            return (float_6 >= float_7) ? ((float_6 <= float_8) ? float_6 : float_8) : float_7;
        }

        public static int smethod_32(int int_0, int int_1, int int_2)
        {
            return (int_0 >= int_1) ? ((int_0 <= int_2) ? int_0 : int_2) : int_1;
        }

        public static float smethod_33(float float_6)
        {
            return Mathf.smethod_31(float_6, 0f, 1f);
        }

        public static float smethod_34(float float_6, float float_7, float float_8)
        {
            return float_6 + (float_7 - float_6) * Mathf.smethod_33(float_8);
        }

        public static float smethod_35(float float_6, float float_7, float float_8)
        {
            float num = Mathf.smethod_41(float_7 - float_6, 360f);
            if (num > 180f)
            {
                num -= 360f;
            }
            return float_6 + num * Mathf.smethod_33(float_8);
        }

        public static float smethod_36(float float_6, float float_7, float float_8)
        {
            if (Mathf.smethod_8(float_7 - float_6) <= float_8)
            {
                return float_7;
            }
            return float_6 + Mathf.smethod_30(float_7 - float_6) * float_8;
        }

        public static float smethod_37(float float_6, float float_7, float float_8)
        {
            float_7 = float_6 + Mathf.smethod_44(float_6, float_7);
            return Mathf.smethod_36(float_6, float_7, float_8);
        }

        public static float smethod_38(float float_6, float float_7, float float_8)
        {
            float_8 = Mathf.smethod_33(float_8);
            float_8 = -2f * float_8 * float_8 * float_8 + 3f * float_8 * float_8;
            return float_7 * float_8 + float_6 * (1f - float_8);
        }

        public static float smethod_39(float float_6, float float_7, float float_8)
        {
            bool flag = false;
            if (float_6 < 0f)
            {
                flag = true;
            }
            float num = Mathf.smethod_8(float_6);
            if (num > float_7)
            {
                return flag ? (-num) : num;
            }
            float num2 = Mathf.smethod_18(num / float_7, float_8) * float_7;
            return flag ? (-num2) : num2;
        }

        public static bool smethod_40(float float_6, float float_7)
        {
            return Mathf.smethod_8(float_7 - float_6) < Mathf.smethod_14(1E-06f * Mathf.smethod_14(Mathf.smethod_8(float_6), Mathf.smethod_8(float_7)), 1.121039E-44f);
        }

        public static float smethod_41(float float_6, float float_7)
        {
            return float_6 - Mathf.smethod_24(float_6 / float_7) * float_7;
        }

        public static float smethod_42(float float_6, float float_7)
        {
            float_6 = Mathf.smethod_41(float_6, float_7 * 2f);
            return float_7 - Math.Abs(float_6 - float_7);
        }

        public static float smethod_43(float float_6, float float_7, float float_8)
        {
            if (float_6 < float_7)
            {
                if (float_8 < float_6)
                {
                    return 0f;
                }
                if (float_8 > float_7)
                {
                    return 1f;
                }
                float_8 -= float_6;
                float_8 /= float_7 - float_6;
                return float_8;
            }
            else
            {
                if (float_6 <= float_7)
                {
                    return 0f;
                }
                if (float_8 < float_7)
                {
                    return 1f;
                }
                if (float_8 > float_6)
                {
                    return 0f;
                }
                return 1f - (float_8 - float_7) / (float_6 - float_7);
            }
        }

        public static float smethod_44(float float_6, float float_7)
        {
            float num = Mathf.smethod_41(float_7 - float_6, 360f);
            if (num > 180f)
            {
                num -= 360f;
            }
            return num;
        }

        internal static bool smethod_45(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2, Vector2 vector2_3, ref Vector2 vector2_4)
        {
            float num = vector2_1.x - vector2_0.x;
            float num2 = vector2_1.y - vector2_0.y;
            float num3 = vector2_3.x - vector2_2.x;
            float num4 = vector2_3.y - vector2_2.y;
            float num5 = num * num4 - num2 * num3;
            if (num5 == 0f)
            {
                return false;
            }
            float num6 = vector2_2.x - vector2_0.x;
            float num7 = vector2_2.y - vector2_0.y;
            float num8 = (num6 * num4 - num7 * num3) / num5;
            vector2_4 = new Vector2(vector2_0.x + num8 * num, vector2_0.y + num8 * num2);
            return true;
        }

        internal static bool smethod_46(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2, Vector2 vector2_3, ref Vector2 vector2_4)
        {
            float num = vector2_1.x - vector2_0.x;
            float num2 = vector2_1.y - vector2_0.y;
            float num3 = vector2_3.x - vector2_2.x;
            float num4 = vector2_3.y - vector2_2.y;
            float num5 = num * num4 - num2 * num3;
            if (num5 == 0f)
            {
                return false;
            }
            float num6 = vector2_2.x - vector2_0.x;
            float num7 = vector2_2.y - vector2_0.y;
            float num8 = (num6 * num4 - num7 * num3) / num5;
            if (num8 < 0f || num8 > 1f)
            {
                return false;
            }
            float num9 = (num6 * num2 - num7 * num) / num5;
            if (num9 >= 0f && num9 <= 1f)
            {
                vector2_4 = new Vector2(vector2_0.x + num8 * num, vector2_0.y + num8 * num2);
                return true;
            }
            return false;
        }

        public static float smethod_47(float float_6)
        {
            return (float)((int)float_6);
        }

        public static float smethod_48(float float_6)
        {
            float num = float_6 - Mathf.smethod_47(float_6);
            if (float_6 < 0f)
            {
                num *= -1f;
            }
            return num;
        }

        public const float float_0 = 3.14159274f;

        public const float float_1 = float.PositiveInfinity;

        public const float float_2 = float.NegativeInfinity;

        public const float float_3 = 0.0174532924f;

        public const float float_4 = 57.29578f;

        public const float float_5 = 1.401298E-45f;
    }
}
