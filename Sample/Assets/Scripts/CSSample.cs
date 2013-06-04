using UnityEngine;
using System.Collections;

public class CSSample : MonoBehaviour
{
    public string stringWithoutTooltip = ":(";
    [Tooltip("A sample tooltip in C#")]
    public string stringWithTooltip = ":)";
}
