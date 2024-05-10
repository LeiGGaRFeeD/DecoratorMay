using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HotdogDebug))]
public class HotdogDebugEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        HotdogDebug script = (HotdogDebug)target;

        if (GUILayout.Button("Test Hotdogs"))
        {
            script.TestHotdogs();
        }
    }
}
#endif
