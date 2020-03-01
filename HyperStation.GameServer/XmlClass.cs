using System;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using HyperStation.GameServer;
//using Cwave;
//using UnityEngine;

[Serializable]
public abstract class XmlClass
{
    public XmlClass()
    {
        this.SetDefaultValue(null, null, null);
    }

    public XmlClass(string node, string totalPath, XmlNode topNode)
    {
        this.SetDefaultValue(node, totalPath, topNode);
        this.Load(node, totalPath, topNode);
    }

    public static Type GetListElementType(Type type)
    {
        Type result;
        if (type.HasElementType)
        {
            result = type.GetElementType();
        }
        else if (type.IsGenericType && type.GetGenericArguments().Length == 1)
        {
            result = type.GetGenericArguments()[0];
        }
        else
        {
            result = type;
        }
        return result;
    }

    protected virtual void SetDefaultValue(string node, string totalPath, XmlNode topNode)
    {
    }

    private void Load(string xmlKey, string totalPath, XmlNode topNode)
    {
        if (topNode == null)
        {
            return;
        }
        FieldInfo[] fields = this.GetFields();
        foreach (FieldInfo fieldInfo in fields)
        {
            global::XmlAttribute xmlAttribute = XmlClass.GetXmlAttribute(fieldInfo);
            if (xmlAttribute != null)
            {
                string memberTotalPath = this.GetMemberTotalPath(xmlAttribute, totalPath);
                if (memberTotalPath != null && memberTotalPath.Length != 0)
                {
                    this.SetField(fieldInfo, topNode, xmlKey, memberTotalPath, xmlAttribute.IsStandard);
                }
            }
        }
    }

    private string GetMemberTotalPath(global::XmlAttribute fieldAttr, string totalPath)
    {
        if (fieldAttr == null)
        {
            return null;
        }
        if (totalPath.Length == 0)
        {
            return fieldAttr.Path;
        }
        return totalPath + "/" + fieldAttr.Path;
    }

    public static FieldInfo[] GetFields(Type type)
    {
        return type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    }

    public FieldInfo[] GetFields()
    {
        return XmlClass.GetFields(base.GetType());
    }

    public static global::XmlAttribute GetXmlAttribute(FieldInfo fieldInfo)
    {
        return fieldInfo.GetCustomAttributes(typeof(global::XmlAttribute), false).Cast<global::XmlAttribute>().SingleOrDefault<global::XmlAttribute>();
    }

    private void SetField(FieldInfo info, XmlNode topNode, string xmlKey, string memTotalPath, bool isStandard)
    {
        if (info != null && topNode != null)
        {
            if (info.FieldType.IsGenericType)
            {
                this.SetField_Generic(info, topNode, xmlKey, memTotalPath);
            }
            else if (XmlClass.IsClassType(info.FieldType))
            {
                this.SetField_Class(info, topNode, xmlKey, memTotalPath, isStandard);
            }
            else
            {
                XmlNode xmlNode = this.NodeFind(topNode, memTotalPath);
                if (xmlNode == null)
                {
                    return;
                }
                try
                {
                    object value = this.GetValue(info.FieldType, xmlNode.InnerText);
                    if (value != null)
                    {
                        info.SetValue(this, value);
                    }
                }
                catch (Exception ex)
                {
                    string str = memTotalPath + "/" + xmlNode.Name;
                    throw new Exception("[Xml Parsing Error] Path : " + str + "\r\n" + ex.ToString());
                }
            }
            return;
        }
    }

    private void SetField_Generic(FieldInfo info, XmlNode topNode, string xmlKey, string memTotalPath)
    {
        if (info == null || topNode == null || memTotalPath.Length == 0)
        {
            return;
        }
        if (!info.FieldType.IsGenericType)
        {
            return;
        }
        XmlNode xmlNode = this.NodeFind(topNode, memTotalPath);
        if (xmlNode == null)
        {
            return;
        }
        Type listElementType = XmlClass.GetListElementType(info.FieldType);
        bool flag = XmlClass.IsClassType(listElementType) && xmlNode.ChildNodes.Count > 0 && !listElementType.IsGenericType;
        bool flag2 = listElementType.IsGenericType && xmlNode.ChildNodes.Count > 0;
        bool flag3 = false;
        if (!XmlClass.IsClassType(listElementType) && xmlNode.ChildNodes.Count > 0)
        {
            int num = 0;
            for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
            {
                flag3 = int.TryParse(xmlNode.ChildNodes[i].InnerText, out num);
            }
        }
        bool flag4 = !flag2 && !XmlClass.IsClassType(listElementType) && xmlNode.InnerText.Length > 0;
        if (!flag && !flag3 && !flag2 && !flag4)
        {
            return;
        }
        MethodInfo method = info.FieldType.GetMethod("Clear");
        MethodInfo method2 = info.FieldType.GetMethod("Add");
        object value = info.GetValue(this);
        if (value == null)
        {
            object value2 = Activator.CreateInstance(info.FieldType, null);
            info.SetValue(this, value2);
            value = info.GetValue(this);
        }
        if (method != null && value != null)
        {
            method.Invoke(value, null);
        }
        if (flag)
        {
            for (int j = 0; j < xmlNode.ChildNodes.Count; j++)
            {
                string text = memTotalPath + "/" + xmlNode.ChildNodes[j].Name;
                try
                {
                    object obj = Activator.CreateInstance(listElementType, new object[]
                    {
                        xmlKey,
                        text,
                        topNode
                    });
                    if (method2 != null && value != null)
                    {
                        method2.Invoke(value, new object[]
                        {
                            obj
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("[Xml Parsing Error] Path : " + text + "\r\n" + ex.ToString());
                }
            }
        }
        else if (flag2)
        {
            Type listElementType2 = XmlClass.GetListElementType(listElementType);
            MethodInfo method3 = listElementType.GetMethod("Add");
            for (int k = 0; k < xmlNode.ChildNodes.Count; k++)
            {
                string[] array = xmlNode.ChildNodes[k].InnerText.Split(new char[]
                {
                    ','
                });
                if (array != null)
                {
                    try
                    {
                        object obj2 = Activator.CreateInstance(listElementType, null);
                        foreach (string dataText in array)
                        {
                            object value3 = this.GetValue(listElementType2, dataText);
                            if (value3 != null && method3 != null && obj2 != null)
                            {
                                method3.Invoke(obj2, new object[]
                                {
                                    value3
                                });
                            }
                        }
                        if (method2 != null && value != null)
                        {
                            method2.Invoke(value, new object[]
                            {
                                obj2
                            });
                        }
                    }
                    catch (Exception ex2)
                    {
                        string str = memTotalPath + "/" + xmlNode.ChildNodes[k].Name;
                        throw new Exception("[Xml Parsing Error] Path : " + str + "\r\n" + ex2.ToString());
                    }
                }
            }
        }
        else if (flag3)
        {
            for (int m = 0; m < xmlNode.ChildNodes.Count; m++)
            {
                try
                {
                    object value4 = this.GetValue(listElementType, xmlNode.ChildNodes[m].InnerText);
                    if (value4 != null && method2 != null && value != null)
                    {
                        method2.Invoke(value, new object[]
                        {
                            value4
                        });
                    }
                }
                catch (Exception ex3)
                {
                    string str2 = memTotalPath + "/" + xmlNode.ChildNodes[m].Name;
                    throw new Exception("[Xml Parsing Error] Path : " + str2 + "\r\n" + ex3.ToString());
                }
            }
        }
        else if (flag4)
        {
            try
            {
                string[] array3 = xmlNode.InnerText.Split(new char[]
                {
                    ','
                });
                foreach (string dataText2 in array3)
                {
                    object value5 = this.GetValue(listElementType, dataText2);
                    if (value5 != null && method2 != null && value != null)
                    {
                        method2.Invoke(value, new object[]
                        {
                            value5
                        });
                    }
                }
            }
            catch (Exception ex4)
            {
                string str3 = memTotalPath + "/" + xmlNode.Name;
                throw new Exception("[Xml Parsing Error] Path : " + str3 + "\r\n" + ex4.ToString());
            }
        }
    }

    private void SetField_Class(FieldInfo info, XmlNode topNode, string xmlKey, string memTotalPath, bool isStandard)
    {
        if (info == null || topNode == null || memTotalPath.Length == 0)
        {
            return;
        }
        if (info.FieldType.IsGenericType || !XmlClass.IsClassType(info.FieldType))
        {
            return;
        }
        XmlNode xmlNode = this.NodeFind(topNode, memTotalPath);
        if (xmlNode == null)
        {
            return;
        }
        object value = null;
        if (isStandard)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(info.FieldType);
            using (XmlNodeReader xmlNodeReader = new XmlNodeReader(xmlNode))
            {
                value = xmlSerializer.Deserialize(xmlNodeReader);
                goto IL_8C;
            }
        }
        value = Activator.CreateInstance(info.FieldType, new object[]
        {
            xmlKey,
            memTotalPath,
            topNode
        });
    IL_8C:
        info.SetValue(this, value);
    }

    private object GetValue(Type type, string dataText)
    {
        object result = null;
        if (dataText.Equals(string.Empty))
        {
            return null;
        }
        try
        {
            if (type.IsEnum)
            {
                if (dataText.Contains(','))
                {
                    string[] array = dataText.Split(new char[]
                    {
                        ','
                    });
                    int num = 0;
                    foreach (string value in array)
                    {
                        num |= (int)Enum.Parse(type, value, false);
                    }
                    result = num;
                }
                else
                {
                    result = Enum.Parse(type, dataText, false);
                }
            }
            /*else if (type == typeof(UnityEngine.Vector3))
            {
                string[] array3 = dataText.Split(new char[]
                {
                    ','
                });
                if (array3.Length == 3)
                {
                    result = new UnityEngine.Vector3(Convert.ToSingle(array3[0]), Convert.ToSingle(array3[1]), Convert.ToSingle(array3[2]));
                }
            }*/
            /*else if (type == typeof(Cwave.Vector3))
            {
                string[] array4 = dataText.Split(new char[]
                {
                    ','
                });
                if (array4.Length == 3)
                {
                    result = new Cwave.Vector3(Convert.ToSingle(array4[0]), Convert.ToSingle(array4[1]), Convert.ToSingle(array4[2]));
                }
            }*/
            /*else if (type == typeof(UnityEngine.Vector2))
            {
                string[] array5 = dataText.Split(new char[]
                {
                    ','
                });
                if (array5.Length == 2)
                {
                    result = new UnityEngine.Vector2(Convert.ToSingle(array5[0]), Convert.ToSingle(array5[1]));
                }
            }*/
            /*else if (type == typeof(Cwave.Vector2))
            {
                string[] array6 = dataText.Split(new char[]
                {
                    ','
                });
                if (array6.Length == 2)
                {
                    result = new Cwave.Vector2(Convert.ToSingle(array6[0]), Convert.ToSingle(array6[1]));
                }
            }*/
            /*else if (type == typeof(Color))
            {
                string[] array7 = dataText.Split(new char[]
                {
                    ','
                });
                if (array7.Length == 3)
                {
                    result = new Color(Convert.ToSingle(array7[0]), Convert.ToSingle(array7[1]), Convert.ToSingle(array7[2]));
                }
            }*/
            /*else if (type == typeof(Cwave.Color32))
            {
                string[] array8 = dataText.Split(new char[]
                {
                    ','
                });
                if (array8.Length == 3)
                {
                    result = new Cwave.Color32(Convert.ToByte(array8[0]), Convert.ToByte(array8[1]), Convert.ToByte(array8[2]), byte.MaxValue);
                }
            }*/
            else if (type == typeof(SkillID))
            {
                result = new SkillID(dataText);
            }
            else if (type == typeof(ItemID))
            {
                result = new ItemID(dataText);
            }
            else if (type == typeof(SkillBuffID))
            {
                result = new SkillBuffID(dataText);
            }
            else if (type == typeof(PawnClassID))
            {
                result = new PawnClassID(dataText);
            }
            else if (type == typeof(PawnBodyID))
            {
                result = new PawnBodyID(dataText);
            }
            /*else if (type == typeof(ItemBoxID))
            {
                result = new ItemBoxID(dataText);
            }*/
            else if (type == typeof(SkillOptionID))
            {
                result = new SkillOptionID(dataText);
            }
            /*else if (type == typeof(SkillProjectileID))
            {
                result = new SkillProjectileID(dataText);
            }*/
            /*else if (type == typeof(RTLB))
            {
                result = new RTLB(dataText);
            }*/
            else if (type == typeof(MapID))
            {
                result = new MapID(dataText);
            }
            else
            {
                result = Convert.ChangeType(dataText, type);
            }
        }
        catch (Exception innerException)
        {
            string message = "[XmlClass] Invalid Value! Type:" + type.ToString() + " Value: " + dataText;
            throw new Exception(message, innerException);
        }
        return result;
    }

    protected XmlNode NodeFind(XmlNode node, string childPath)
    {
        XmlNodeList xmlNodeList = node.SelectNodes(childPath);
        if (xmlNodeList != null && xmlNodeList.Count > 0)
        {
            return xmlNodeList[0];
        }
        return null;
    }

    public static bool IsClassType(Type type)
    {
        return type.IsClass && type != typeof(string);
    }
}
