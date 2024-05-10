using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogTester
{
    public static void TestHotdogs(HotdogData classicData, DecorationData pickleData, DecorationData sweetOnionData)
    {
        Hotdog classic = new ClassicHotdog(classicData);
        Hotdog classicWithPickle = new PickleDecorator(classic, pickleData);
        Hotdog classicWithSweetOnion = new SweetOnionDecorator(classic, sweetOnionData);

        Debug.Log($"{classic.GetName()} ({classic.GetWeight()}�) � {classic.GetCost()}�.");
        Debug.Log($"DLC Hot Dogs:");
        Debug.Log($"{classicWithPickle.GetName()} ({classicWithPickle.GetWeight()}�) � {classicWithPickle.GetCost()}�.");
        Debug.Log($"{classicWithSweetOnion.GetName()} ({classicWithSweetOnion.GetWeight()}�) � {classicWithSweetOnion.GetCost()}�.");
    }
}