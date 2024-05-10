using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweetOnionDecorator : HotdogDecorator
{
    public SweetOnionDecorator(Hotdog hotdog, DecorationData decorationData) : base(hotdog, decorationData)
    {
    }

    public override string GetName()
    {
        return $"{hotdog.GetName()} ñ {decorationData.decorationName}";
    }
}