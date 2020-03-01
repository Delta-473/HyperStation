using System;
using System.Collections.Generic;
using System.Xml;

namespace ns4
{
    public abstract class BaseStatData<T> : XmlClass
    {
        public BaseStatData()
        {
            if (!typeof(T).IsEnum)
            {
                //GInstance.GLog.logFuncType_2("[TypeError] Use Enum Type!");
            }
        }

        public BaseStatData(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public BaseStatData(BaseStatData<T> other)
        {
            if (other == null)
            {
                return;
            }
            this._stat = new Dictionary<T, int>(other._stat);
        }

        public virtual void Add(BaseStatData<T> other)
        {
            if (other == null)
            {
                return;
            }
            foreach (KeyValuePair<T, int> keyValuePair in other._stat)
            {
                Dictionary<T, int> stat;
                Dictionary<T, int> dictionary = stat = this._stat;
                T key2;
                T key = key2 = keyValuePair.Key;
                int num = stat[key2];
                dictionary[key] = num + keyValuePair.Value;
            }
        }

        protected override void SetDefaultValue(string node, string totalPath, XmlNode topNode)
        {
            if (node == null)
            {
                return;
            }
            this.Read(totalPath, topNode);
        }

        protected void Read(string totalPath, XmlNode topNode)
        {
            if (topNode != null)
            {
                foreach (object obj in Enum.GetValues(typeof(T)))
                {
                    T flag = (T)((object)obj);
                    this.ReadValue(topNode, totalPath, flag);
                }
            }
        }

        protected bool ReadValue(XmlNode topNode, string totalPath, T flag)
        {
            string text = flag.ToString();
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

        public void SetValue(T flag, int val)
        {
            this._stat[flag] = val;
        }

        public int GetValue(T flag)
        {
            return this._stat[flag];
        }

        public Dictionary<T, int> _stat = new Dictionary<T, int>();
    }
}
