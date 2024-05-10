using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog hotdog;
    protected DecorationData decorationData;

    public HotdogDecorator(Hotdog hotdog, DecorationData decorationData) : base(hotdog.data)
    {
        this.hotdog = hotdog;
        this.decorationData = decorationData;
    }

    public override int GetCost()
    {
        return hotdog.GetCost() + decorationData.additionalCost;
    }

    public override int GetWeight()
    {
        return hotdog.GetWeight() + decorationData.additionalWeight;
    }
}