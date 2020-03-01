using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperStation.GameServer
{
    [Serializable]
    public struct Vector2
    {
        public const float float_0 = 1E-05f;
        public float x;
        public float y;

        public Vector2(float float_1, float float_2)
        {
            this.x = float_1;
            this.y = float_2;
        }

        public float this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return this.x;
                }
                if (index != 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid Vector2 index!");
                }
                return this.y;
            }
            set
            {
                if (index != 0)
                {
                    if (index != 1)
                    {
                        throw new IndexOutOfRangeException("Invalid Vector2 index!");
                    }
                    this.y = value;
                }
                else
                {
                    this.x = value;
                }
            }
        }

        public Vector2 normalized
        {
            get
            {
                Vector2 result = new Vector2(this.x, this.y);
                result.method_2();
                return result;
            }
        }

        public float magnitude
        {
            get
            {
                return Mathf.smethod_7(this.x * this.x + this.y * this.y);
            }
        }

        public float sqrMagnitude
        {
            get
            {
                return this.x * this.x + this.y * this.y;
            }
        }

        public static Vector2 zero
        {
            get
            {
                return new Vector2(0f, 0f);
            }
        }

        public static Vector2 one
        {
            get
            {
                return new Vector2(1f, 1f);
            }
        }

        public static Vector2 up
        {
            get
            {
                return new Vector2(0f, 1f);
            }
        }

        public static Vector2 right
        {
            get
            {
                return new Vector2(1f, 0f);
            }
        }

        public void method_0(float float_1, float float_2)
        {
            this.x = float_1;
            this.y = float_2;
        }

        public static Vector2 smethod_0(Vector2 vector2_0, Vector2 vector2_1, float float_1)
        {
            float_1 = Mathf.smethod_33(float_1);
            return new Vector2(vector2_0.x + (vector2_1.x - vector2_0.x) * float_1, vector2_0.y + (vector2_1.y - vector2_0.y) * float_1);
        }

        public static Vector2 smethod_1(Vector2 vector2_0, Vector2 vector2_1, float float_1)
        {
            Vector2 vector2_2 = Vector2.smethod_11(vector2_1, vector2_0);
            float magnitude = vector2_2.magnitude;
            if (magnitude > float_1)
            {
                if (magnitude != 0f)
                {
                    return Vector2.smethod_10(vector2_0, Vector2.smethod_13(Vector2.smethod_15(vector2_2, magnitude), float_1));
                }
            }
            return vector2_1;
        }

        public static Vector2 smethod_2(Vector2 vector2_0, Vector2 vector2_1)
        {
            return new Vector2(vector2_0.x * vector2_1.x, vector2_0.y * vector2_1.y);
        }

        public void method_1(Vector2 vector2_0)
        {
            this.x *= vector2_0.x;
            this.y *= vector2_0.y;
        }

        public void method_2()
        {
            float magnitude = this.magnitude;
            if (magnitude > 1E-05f)
            {
                this = Vector2.smethod_15(this, magnitude);
            }
            else
            {
                this = Vector2.zero;
            }
        }

        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1})", new object[]
            {
                this.x,
                this.y
            });
        }

        public string method_3(string string_0)
        {
            return string.Format("({0}, {1})", new object[]
            {
                this.x.ToString(string_0),
                this.y.ToString(string_0)
            });
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector2))
            {
                return false;
            }
            Vector2 vector = (Vector2)other;
            return this.x.Equals(vector.x) && this.y.Equals(vector.y);
        }

        public bool method_4(Vector2 vector2_0)
        {
            return this.x.Equals(vector2_0.x) && this.y.Equals(vector2_0.y);
        }

        public static float smethod_3(Vector2 vector2_0, Vector2 vector2_1)
        {
            return vector2_0.x * vector2_1.x + vector2_0.y * vector2_1.y;
        }

        public static float smethod_4(Vector2 vector2_0, Vector2 vector2_1)
        {
            return Mathf.smethod_4(Mathf.smethod_31(Vector2.smethod_3(vector2_0.normalized, vector2_1.normalized), -1f, 1f)) * 57.29578f;
        }

        public static float smethod_5(Vector2 vector2_0, Vector2 vector2_1)
        {
            return Vector2.smethod_11(vector2_0, vector2_1).magnitude;
        }

        public static Vector2 smethod_6(Vector2 vector2_0, float float_1)
        {
            if (vector2_0.sqrMagnitude > float_1 * float_1)
            {
                return Vector2.smethod_13(vector2_0.normalized, float_1);
            }
            return vector2_0;
        }

        public static float smethod_7(Vector2 vector2_0)
        {
            return vector2_0.x * vector2_0.x + vector2_0.y * vector2_0.y;
        }

        public float method_5()
        {
            return this.x * this.x + this.y * this.y;
        }

        public static Vector2 smethod_8(Vector2 vector2_0, Vector2 vector2_1)
        {
            return new Vector2(Mathf.smethod_10(vector2_0.x, vector2_1.x), Mathf.smethod_10(vector2_0.y, vector2_1.y));
        }

        public static Vector2 smethod_9(Vector2 vector2_0, Vector2 vector2_1)
        {
            return new Vector2(Mathf.smethod_14(vector2_0.x, vector2_1.x), Mathf.smethod_14(vector2_0.y, vector2_1.y));
        }

        public static Vector2 smethod_10(Vector2 vector2_0, Vector2 vector2_1)
        {
            return new Vector2(vector2_0.x + vector2_1.x, vector2_0.y + vector2_1.y);
        }

        public static Vector2 smethod_11(Vector2 vector2_0, Vector2 vector2_1)
        {
            return new Vector2(vector2_0.x - vector2_1.x, vector2_0.y - vector2_1.y);
        }

        public static Vector2 smethod_12(Vector2 vector2_0)
        {
            return new Vector2(-vector2_0.x, -vector2_0.y);
        }

        public static Vector2 smethod_13(Vector2 vector2_0, float float_1)
        {
            return new Vector2(vector2_0.x * float_1, vector2_0.y * float_1);
        }

        public static Vector2 smethod_14(float float_1, Vector2 vector2_0)
        {
            return new Vector2(vector2_0.x * float_1, vector2_0.y * float_1);
        }

        public static Vector2 smethod_15(Vector2 vector2_0, float float_1)
        {
            return new Vector2(vector2_0.x / float_1, vector2_0.y / float_1);
        }

        public static bool smethod_16(Vector2 vector2_0, Vector2 vector2_1)
        {
            return Vector2.smethod_7(Vector2.smethod_11(vector2_0, vector2_1)) < 9.99999944E-11f;
        }

        public static bool smethod_17(Vector2 vector2_0, Vector2 vector2_1)
        {
            return Vector2.smethod_7(Vector2.smethod_11(vector2_0, vector2_1)) >= 9.99999944E-11f;
        }

        public static Vector2 smethod_18(Vector3 vector3_0)
        {
            return new Vector2(vector3_0.x, vector3_0.y);
        }

        public static Vector3 smethod_19(Vector2 vector2_0)
        {
            return new Vector3(vector2_0.x, vector2_0.y, 0f);
        }

        public static Vector2 smethod_20(Vector2 vector2_0)
        {
            return new Vector2(vector2_0.x, vector2_0.y);
        }

        public static Vector2 smethod_21(Vector2 vector2_0)
        {
            return new Vector2(vector2_0.x, vector2_0.y);
        }
    }
}
