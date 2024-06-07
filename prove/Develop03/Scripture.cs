using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string reference;
    private string text;

    public string Reference
    {
        get { return reference; }
        set { reference = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }
}
