using UnityEngine;
using System.Collections;

public class Tooltip : PropertyAttribute
{
    public string text;

    public Tooltip(string TooltipText)
    {
        this.text = TooltipText;
    }
}