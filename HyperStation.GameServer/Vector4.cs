using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperStation.GameServer
{
    [Serializable]
    public struct Vector4
    {
        public const float float_0 = 1E-05f;
        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4(float float_1, float float_2, float float_3, float float_4)
        {
            this.x = float_1;
            this.y = float_2;
            this.z = float_3;
            this.w = float_4;
        }

        public Vector4(float float_1, float float_2, float float_3)
        {
            this.x = float_1;
            this.y = float_2;
            this.z = float_3;
            this.w = 0f;
        }

        public Vector4(float float_1, float float_2)
        {
            this.x = float_1;
            this.y = float_2;
            this.z = 0f;
            this.w = 0f;
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.x;
                    case 1:
                        return this.y;
                    case 2:
                        return this.z;
                    case 3:
                        return this.w;
                    default:
                        throw new ArgumentOutOfRangeException("Invalid Vector4 index!");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    case 2:
                        this.z = value;
                        break;
                    case 3:
                        this.w = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector4 index!");
                }
            }
        }

        public Vector4 normalized
        {
            get
            {
                return Vector4.smethod_3(this);
            }
        }

        public float magnitude
        {
            get
            {
                return Mathf.smethod_7(Vector4.smethod_4(this, this));
            }
        }

        public float sqrMagnitude
        {
            get
            {
                return Vector4.smethod_4(this, this);
            }
        }

        public static Vector4 zero
        {
            get
            {
                return new Vector4(0f, 0f, 0f, 0f);
            }
        }

        public static Vector4 one
        {
            get
            {
                return new Vector4(1f, 1f, 1f, 1f);
            }
        }

        public void method_0(float float_1, float float_2, float float_3, float float_4)
        {
            this.x = float_1;
            this.y = float_2;
            this.z = float_3;
            this.w = float_4;
        }

        public static Vector4 smethod_0(Vector4 vector4_0, Vector4 vector4_1, float float_1)
        {
            float_1 = Mathf.smethod_33(float_1);
            return new Vector4(vector4_0.x + (vector4_1.x - vector4_0.x) * float_1, vector4_0.y + (vector4_1.y - vector4_0.y) * float_1, vector4_0.z + (vector4_1.z - vector4_0.z) * float_1, vector4_0.w + (vector4_1.w - vector4_0.w) * float_1);
        }

        public static Vector4 smethod_1(Vector4 vector4_0, Vector4 vector4_1, float float_1)
        {
            Vector4 vector4_2 = Vector4.smethod_12(vector4_1, vector4_0);
            float magnitude = vector4_2.magnitude;
            if (magnitude > float_1)
            {
                if (magnitude != 0f)
                {
                    return Vector4.smethod_11(vector4_0, Vector4.smethod_14(Vector4.smethod_16(vector4_2, magnitude), float_1));
                }
            }
            return vector4_1;
        }

        public static Vector4 smethod_2(Vector4 vector4_0, Vector4 vector4_1)
        {
            return new Vector4(vector4_0.x * vector4_1.x, vector4_0.y * vector4_1.y, vector4_0.z * vector4_1.z, vector4_0.w * vector4_1.w);
        }

        public void method_1(Vector4 vector4_0)
        {
            this.x *= vector4_0.x;
            this.y *= vector4_0.y;
            this.z *= vector4_0.z;
            this.w *= vector4_0.w;
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2 ^ this.w.GetHashCode() >> 1;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector4))
            {
                return false;
            }
            Vector4 vector = (Vector4)other;
            return this.x.Equals(vector.x) && this.y.Equals(vector.y) && this.z.Equals(vector.z) && this.w.Equals(vector.w);
        }

        public bool method_2(Vector4 vector4_0)
        {
            return this.x.Equals(vector4_0.x) && this.y.Equals(vector4_0.y) && this.z.Equals(vector4_0.z) && this.w.Equals(vector4_0.w);
        }

        public static Vector4 smethod_3(Vector4 vector4_0)
        {
            float num = Vector4.smethod_7(vector4_0);
            if (num > 1E-05f)
            {
                return Vector4.smethod_16(vector4_0, num);
            }
            return Vector4.zero;
        }

        public void method_3()
        {
            float num = Vector4.smethod_7(this);
            if (num > 1E-05f)
            {
                this = Vector4.smethod_16(this, num);
            }
            else
            {
                this = Vector4.zero;
            }
        }

        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", new object[]
            {
                this.x,
                this.y,
                this.z,
                this.w
            });
        }

        public string method_4(string string_0)
        {
            return string.Format("({0}, {1}, {2}, {3})", new object[]
            {
                this.x.ToString(string_0),
                this.y.ToString(string_0),
                this.z.ToString(string_0),
                this.w.ToString(string_0)
            });
        }

        public static float smethod_4(Vector4 vector4_0, Vector4 vector4_1)
        {
            return vector4_0.x * vector4_1.x + vector4_0.y * vector4_1.y + vector4_0.z * vector4_1.z + vector4_0.w * vector4_1.w;
        }

        public static Vector4 smethod_5(Vector4 vector4_0, Vector4 vector4_1)
        {
            return Vector4.smethod_16(Vector4.smethod_14(vector4_1, Vector4.smethod_4(vector4_0, vector4_1)), Vector4.smethod_4(vector4_1, vector4_1));
        }

        public static float smethod_6(Vector4 vector4_0, Vector4 vector4_1)
        {
            return Vector4.smethod_7(Vector4.smethod_12(vector4_0, vector4_1));
        }

        public static float smethod_7(Vector4 vector4_0)
        {
            return Mathf.smethod_7(Vector4.smethod_4(vector4_0, vector4_0));
        }

        public static float smethod_8(Vector4 vector4_0)
        {
            return Vector4.smethod_4(vector4_0, vector4_0);
        }

        public float method_5()
        {
            return Vector4.smethod_4(this, this);
        }

        public static Vector4 smethod_9(Vector4 vector4_0, Vector4 vector4_1)
        {
            return new Vector4(Mathf.smethod_10(vector4_0.x, vector4_1.x), Mathf.smethod_10(vector4_0.y, vector4_1.y), Mathf.smethod_10(vector4_0.z, vector4_1.z), Mathf.smethod_10(vector4_0.w, vector4_1.w));
        }

        public static Vector4 smethod_10(Vector4 vector4_0, Vector4 vector4_1)
        {
            return new Vector4(Mathf.smethod_14(vector4_0.x, vector4_1.x), Mathf.smethod_14(vector4_0.y, vector4_1.y), Mathf.smethod_14(vector4_0.z, vector4_1.z), Mathf.smethod_14(vector4_0.w, vector4_1.w));
        }

        public static Vector4 smethod_11(Vector4 vector4_0, Vector4 vector4_1)
        {
            return new Vector4(vector4_0.x + vector4_1.x, vector4_0.y + vector4_1.y, vector4_0.z + vector4_1.z, vector4_0.w + vector4_1.w);
        }

        public static Vector4 smethod_12(Vector4 vector4_0, Vector4 vector4_1)
        {
            return new Vector4(vector4_0.x - vector4_1.x, vector4_0.y - vector4_1.y, vector4_0.z - vector4_1.z, vector4_0.w - vector4_1.w);
        }

        public static Vector4 smethod_13(Vector4 vector4_0)
        {
            return new Vector4(-vector4_0.x, -vector4_0.y, -vector4_0.z, -vector4_0.w);
        }

        public static Vector4 smethod_14(Vector4 vector4_0, float float_1)
        {
            return new Vector4(vector4_0.x * float_1, vector4_0.y * float_1, vector4_0.z * float_1, vector4_0.w * float_1);
        }

        public static Vector4 smethod_15(float float_1, Vector4 vector4_0)
        {
            return new Vector4(vector4_0.x * float_1, vector4_0.y * float_1, vector4_0.z * float_1, vector4_0.w * float_1);
        }

        public static Vector4 smethod_16(Vector4 vector4_0, float float_1)
        {
            return new Vector4(vector4_0.x / float_1, vector4_0.y / float_1, vector4_0.z / float_1, vector4_0.w / float_1);
        }

        public static bool smethod_17(Vector4 vector4_0, Vector4 vector4_1)
        {
            return Vector4.smethod_8(Vector4.smethod_12(vector4_0, vector4_1)) < 9.99999944E-11f;
        }

        public static bool smethod_18(Vector4 vector4_0, Vector4 vector4_1)
        {
            return Vector4.smethod_8(Vector4.smethod_12(vector4_0, vector4_1)) >= 9.99999944E-11f;
        }

        public static Vector4 smethod_19(Vector3 vector3_0)
        {
            return new Vector4(vector3_0.x, vector3_0.y, vector3_0.z, 0f);
        }

        public static Vector3 smethod_20(Vector4 vector4_0)
        {
            return new Vector3(vector4_0.x, vector4_0.y, vector4_0.z);
        }

        public static Vector4 smethod_21(Vector2 vector2_0)
        {
            return new Vector4(vector2_0.x, vector2_0.y, 0f, 0f);
        }

        public static Vector2 smethod_22(Vector4 vector4_0)
        {
            return new Vector2(vector4_0.x, vector4_0.y);
        }

        public static Vector4 smethod_23(Vector4 vector4_0)
        {
            return new Vector4(vector4_0.x, vector4_0.y, vector4_0.z, vector4_0.w);
        }

        public static Vector4 smethod_24(Vector4 vector4_0)
        {
            return new Vector4(vector4_0.x, vector4_0.y, vector4_0.z, vector4_0.w);
        }
    }
}
