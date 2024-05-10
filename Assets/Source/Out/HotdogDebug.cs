using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogDebug : MonoBehaviour
{
    public HotdogData classicData;
    public DecorationData pickleData;
    public DecorationData sweetOnionData;

    // Этот метод будет вызываться при нажатии кнопки в пользовательском редакторе
    public void TestHotdogs()
    {
        // Вызов статического метода из класса HotdogTester
        HotdogTester.TestHotdogs(classicData, pickleData, sweetOnionData);
    }

    // Вы можете также вызвать TestHotdogs при старте сцены, если это необходимо
    void Start()
    {
        TestHotdogs();
    }
}
