using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HotdogData", menuName = "Hotdog/Create New Hotdog Data")]
public class HotdogData : ScriptableObject
{
    public string hotdogName;
    public int baseCost;
    public int weight;
}