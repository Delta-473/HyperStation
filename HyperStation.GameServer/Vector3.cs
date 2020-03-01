using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace HyperStation.GameServer
{
    [Serializable]
    public struct Vector3 : IXmlSerializable
    {
        public const float kEpsilon = 1E-05f;
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.z = 0f;
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
                    default:
                        throw new ArgumentOutOfRangeException("Invalid Vector3 index!");
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
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector3 index!");
                }
            }
        }

        public Vector3 normalized
        {
            get
            {
                return Vector3.Normalize(this);
            }
        }

        public float magnitude
        {
            get
            {
                return Mathf.smethod_7(this.x * this.x + this.y * this.y + this.z * this.z);
            }
        }

        public float sqrMagnitude
        {
            get
            {
                return this.x * this.x + this.y * this.y + this.z * this.z;
            }
        }

        public static Vector3 zero
        {
            get
            {
                return new Vector3(0f, 0f, 0f);
            }
        }

        public static Vector3 one
        {
            get
            {
                return new Vector3(1f, 1f, 1f);
            }
        }

        public static Vector3 forward
        {
            get
            {
                return new Vector3(0f, 0f, 1f);
            }
        }

        public static Vector3 back
        {
            get
            {
                return new Vector3(0f, 0f, -1f);
            }
        }

        public static Vector3 up
        {
            get
            {
                return new Vector3(0f, 1f, 0f);
            }
        }

        public static Vector3 down
        {
            get
            {
                return new Vector3(0f, -1f, 0f);
            }
        }

        public static Vector3 left
        {
            get
            {
                return new Vector3(-1f, 0f, 0f);
            }
        }

        public static Vector3 right
        {
            get
            {
                return new Vector3(1f, 0f, 0f);
            }
        }

        [Obsolete("Use Vector3.forward instead.")]
        public static Vector3 fwd
        {
            get
            {
                return new Vector3(0f, 0f, 1f);
            }
        }

        public static Vector3 Lerp(Vector3 from, Vector3 to, float t)
        {
            t = Mathf.smethod_33(t);
            return new Vector3(from.x + (to.x - from.x) * t, from.y + (to.y - from.y) * t, from.z + (to.z - from.z) * t);
        }

        public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
        {
            Vector3 a = target - current;
            float magnitude = a.magnitude;
            if (magnitude > maxDistanceDelta)
            {
                if (magnitude != 0f)
                {
                    return current + a / magnitude * maxDistanceDelta;
                }
            }
            return target;
        }

        public void Set(float new_x, float new_y, float new_z)
        {
            this.x = new_x;
            this.y = new_y;
            this.z = new_z;
        }

        public static Vector3 Scale(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public void Scale(Vector3 scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
            this.z *= scale.z;
        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector3))
            {
                return false;
            }
            Vector3 vector = (Vector3)other;
            return this.x.Equals(vector.x) && this.y.Equals(vector.y) && this.z.Equals(vector.z);
        }

        public bool Equals(Vector3 other)
        {
            return this.x.Equals(other.x) && this.y.Equals(other.y) && this.z.Equals(other.z);
        }

        public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
        {
            return -2f * Vector3.Dot(inNormal, inDirection) * inNormal + inDirection;
        }

        public static Vector3 Normalize(Vector3 value)
        {
            float num = Vector3.Magnitude(value);
            if (num > 1E-05f)
            {
                return value / num;
            }
            return Vector3.zero;
        }

        public void Normalize()
        {
            float num = Vector3.Magnitude(this);
            if (num > 1E-05f)
            {
                this /= num;
            }
            else
            {
                this = Vector3.zero;
            }
        }

        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1})", new object[]
            {
                this.x,
                this.y,
                this.z
            });
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1}, {2})", new object[]
            {
                this.x.ToString(format),
                this.y.ToString(format),
                this.z.ToString(format)
            });
        }

        public static Vector3 Parse(string s)
        {
            s = s.Replace("(", string.Empty);
            s = s.Replace(")", string.Empty);
            string[] array = s.Split(new char[]
            {
                ','
            });
            return new Vector3(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]));
        }

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }

        public static Vector3 Project(Vector3 vector, Vector3 onNormal)
        {
            float num = Vector3.Dot(onNormal, onNormal);
            if (num < 1.401298E-45f)
            {
                return Vector3.zero;
            }
            return onNormal * Vector3.Dot(vector, onNormal) / num;
        }

        public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
        {
            return fromThat - Vector3.Project(fromThat, excludeThis);
        }

        public static float Angle(Vector3 from, Vector3 to)
        {
            return Mathf.smethod_4(Mathf.smethod_31(Vector3.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
        }

        public static float Distance(Vector3 a, Vector3 b)
        {
            Vector3 vector = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
            return Mathf.smethod_7(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
        }

        public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
        {
            if (vector.sqrMagnitude > maxLength * maxLength)
            {
                return vector.normalized * maxLength;
            }
            return vector;
        }

        public static float Magnitude(Vector3 a)
        {
            return Mathf.smethod_7(a.x * a.x + a.y * a.y + a.z * a.z);
        }

        public static float SqrMagnitude(Vector3 a)
        {
            return a.x * a.x + a.y * a.y + a.z * a.z;
        }

        public static Vector3 RotateAxisUp(float rotRad)
        {
            return new Vector3
            {
                x = Mathf.smethod_1(-rotRad),
                y = 0f,
                z = Mathf.smethod_0(-rotRad)
            };
        }

        public static float RotationAngleAxisUp(Vector3 v_)
        {
            return Mathf.smethod_6(-v_.z, v_.x);
        }

        public static Vector3 Min(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(Mathf.smethod_10(lhs.x, rhs.x), Mathf.smethod_10(lhs.y, rhs.y), Mathf.smethod_10(lhs.z, rhs.z));
        }

        public static Vector3 Max(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(Mathf.smethod_14(lhs.x, rhs.x), Mathf.smethod_14(lhs.y, rhs.y), Mathf.smethod_14(lhs.z, rhs.z));
        }

        [Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
        public static float AngleBetween(Vector3 from, Vector3 to)
        {
            return Mathf.smethod_4(Mathf.smethod_31(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            string text = reader.ReadString();
            string[] array = text.Split(new char[]
            {
                ','
            });
            if (array.Length == 3)
            {
                this.x = Convert.ToSingle(array[0]);
                this.y = Convert.ToSingle(array[1]);
                this.z = Convert.ToSingle(array[2]);
            }
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.x);
            stringBuilder.Append(",");
            stringBuilder.Append(this.y);
            stringBuilder.Append(",");
            stringBuilder.Append(this.z);
            writer.WriteString(stringBuilder.ToString());
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector3 operator -(Vector3 a)
        {
            return new Vector3(-a.x, -a.y, -a.z);
        }

        public static Vector3 operator *(Vector3 a, float d)
        {
            return new Vector3(a.x * d, a.y * d, a.z * d);
        }

        public static Vector3 operator *(float d, Vector3 a)
        {
            return new Vector3(a.x * d, a.y * d, a.z * d);
        }

        public static Vector3 operator /(Vector3 a, float d)
        {
            return new Vector3(a.x / d, a.y / d, a.z / d);
        }

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return Vector3.SqrMagnitude(lhs - rhs) < 9.99999944E-11f;
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return Vector3.SqrMagnitude(lhs - rhs) >= 9.99999944E-11f;
        }

        /*public static implicit operator Vector3(Vector3 v)
        {
            return new Vector3(v.x, v.y, v.z);
        }*/

        /*public static implicit operator Vector3(Vector3 v)
        {
            return new Vector3(v.x, v.y, v.z);
        }*/

        public static IComparer<Vector3> _DefComparer = new Vector3.Vector3Comparer();

        private class Vector3Comparer : IComparer<Vector3>
        {
            public int Compare(Vector3 lhs, Vector3 rhs)
            {
                if (lhs.x != rhs.x)
                {
                    return (lhs.x <= rhs.x) ? -1 : 1;
                }
                if (lhs.y != rhs.y)
                {
                    return (lhs.y <= rhs.y) ? -1 : 1;
                }
                if (lhs.z == rhs.z)
                {
                    return 0;
                }
                return (lhs.z <= rhs.z) ? -1 : 1;
            }
        }
    }
}
