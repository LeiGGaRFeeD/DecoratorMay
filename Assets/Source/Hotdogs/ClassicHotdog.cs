using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicHotdog : Hotdog
{
    public ClassicHotdog(HotdogData data) : base(data)
    {
    }

    public override int GetCost()
    {
        return data.baseCost;
    }
}