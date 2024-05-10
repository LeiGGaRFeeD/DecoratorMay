using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleDecorator : HotdogDecorator
{
    public PickleDecorator(Hotdog hotdog, DecorationData decorationData) : base(hotdog, decorationData)
    {
    }

    public override string GetName()
    {
        return $"{hotdog.GetName()} ñ {decorationData.decorationName}";
    }
}