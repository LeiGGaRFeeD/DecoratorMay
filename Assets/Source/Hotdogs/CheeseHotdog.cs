using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseHotdog : Hotdog
{
    public CheeseHotdog(HotdogData data) : base(data)
    {
    }

    public override int GetCost()
    {
        return data.baseCost;
    }
}
