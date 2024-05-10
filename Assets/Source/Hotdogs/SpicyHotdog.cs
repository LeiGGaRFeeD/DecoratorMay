using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpicyHotdog : Hotdog
{
    public SpicyHotdog(HotdogData data) : base(data)
    {
    }

    public override int GetCost()
    {
        return data.baseCost;
    }
}