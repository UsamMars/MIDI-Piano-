using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDisplay : MonoBehaviour
{
    public Camera cameraOnMonitor1;
    public Camera cameraOnMonitor2;

    void Start()
    {
        Display.displays[0].Activate(); // Activate the first display
        cameraOnMonitor1.targetDisplay = 0;

        if (Display.displays.Length > 1)
        {
            Display.displays[1].Activate(); // Activate the second display
            cameraOnMonitor2.targetDisplay = 1;
        }
    }
}
