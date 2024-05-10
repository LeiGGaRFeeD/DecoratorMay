using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hotdog
{



    public HotdogData data;

    public Hotdog(HotdogData data)
    {
        this.data = data;
    }

    public virtual string GetName()
    {
        return data.hotdogName;
    }

    public abstract int GetCost();

    public virtual int GetWeight()
    {
        return data.weight;
    }
}