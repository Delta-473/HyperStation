using System;
using System.Xml;

namespace ns4
{
    public class StatCondition : BaseStatData<PawnStat.IntTotalFlag>
    {
        public StatCondition()
        {
        }

        public StatCondition(string node, string totalPath, XmlNode topNode) : base(node, totalPath, topNode)
        {
        }

        public StatCondition(StatCondition other) : base(other)
        {
        }
    }
}
