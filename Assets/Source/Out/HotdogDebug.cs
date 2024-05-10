using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogDebug : MonoBehaviour
{
    public HotdogData classicData;
    public DecorationData pickleData;
    public DecorationData sweetOnionData;

    // ���� ����� ����� ���������� ��� ������� ������ � ���������������� ���������
    public void TestHotdogs()
    {
        // ����� ������������ ������ �� ������ HotdogTester
        HotdogTester.TestHotdogs(classicData, pickleData, sweetOnionData);
    }

    // �� ������ ����� ������� TestHotdogs ��� ������ �����, ���� ��� ����������
    void Start()
    {
        TestHotdogs();
    }
}
