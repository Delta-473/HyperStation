using System;
using System.Collections.Generic;

namespace ns4
{
    public static class Util
    {
        public static void smethod_0(ref int int_0, int int_1)
        {
            Util.smethod_1(ref int_0, int_1, 0);
        }

        public static void smethod_1(ref int int_0, int int_1, int int_2)
        {
            if (int_1 != int_2)
            {
                int_0 += int_1;
            }
        }

        public static void smethod_2(ref float float_0, float float_1)
        {
            Util.smethod_3(ref float_0, float_1, 0f);
        }

        public static void smethod_3(ref float float_0, float float_1, float float_2)
        {
            if (float_1 != float_2)
            {
                float_0 += float_1;
            }
        }

        public static void smethod_4<T>(ref T gparam_0, T gparam_1) where T : class, IAddable<T>, new()
        {
            if (gparam_1 != null)
            {
                if (gparam_0 == null)
                {
                    gparam_0 = Activator.CreateInstance<T>();
                }
                gparam_0.Add(gparam_1);
            }
        }

        public static void smethod_5<T>(ref List<T> list_0, List<T> list_1) where T : class, IAddable<T>, new()
        {
            if (list_1 != null)
            {
                if (list_0 == null)
                {
                    list_0 = new List<T>();
                }
                for (int i = 0; i < list_1.Count; i++)
                {
                    if (list_0[i] == null)
                    {
                        list_0[i] = Activator.CreateInstance<T>();
                    }
                    T t = list_0[i];
                    t.Add(list_1[i]);
                }
            }
        }

        public static void smethod_6(ref int int_0, int int_1)
        {
            Util.smethod_7(ref int_0, int_1, 0);
        }

        public static void smethod_7(ref int int_0, int int_1, int int_2)
        {
            if (int_1 != int_2)
            {
                int_0 = int_0 * int_1 / 100;
            }
        }

        public static void smethod_8(ref float float_0, float float_1)
        {
            Util.smethod_9(ref float_0, float_1, 0f);
        }

        public static void smethod_9(ref float float_0, float float_1, float float_2)
        {
            if (float_1 != float_2)
            {
                float_0 *= float_1 / 100f;
            }
        }

        public static void smethod_10<T>(ref T gparam_0, T gparam_1) where T : class, IMultipliable<T>
        {
            if (gparam_0 != null)
            {
                gparam_0.Multiply(gparam_1);
            }
        }

        public static void smethod_11<T>(ref List<T> list_0, List<T> list_1) where T : class, IMultipliable<T>
        {
            if (list_1 != null)
            {
                for (int i = 0; i < list_1.Count; i++)
                {
                    T t = list_0[i];
                    t.Multiply(list_1[i]);
                }
            }
        }
    }
}
