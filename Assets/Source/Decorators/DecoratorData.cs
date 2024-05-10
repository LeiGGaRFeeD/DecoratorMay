using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DecorationData", menuName = "Hotdog/Create New Decoration Data")]
public class DecorationData : ScriptableObject
{
    public string decorationName;
    public int additionalCost;
    public int additionalWeight;
}