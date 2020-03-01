using System;

[AttributeUsage(AttributeTargets.Field)]
public class XmlAttribute : Attribute
{
    public XmlAttribute(string path)
    {
        this._Path = path;
    }

    public XmlAttribute(string path, bool isStandard)
    {
        this._Path = path;
        this._IsStandard = isStandard;
    }

    public string Path
    {
        get
        {
            return this._Path;
        }
    }

    public bool IsStandard
    {
        get
        {
            return this._IsStandard;
        }
    }

    private string _Path;

    private bool _IsStandard;
}
