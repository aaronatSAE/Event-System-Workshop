using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Only has to worry about the event itself and the triggers for the event.
/// It does not need to know about which specific scripts (Teleporter, ColourChanger).
/// Likewise, the Teleporter and ColourChanger scripts don't need to know about each other.
/// </summary>
public class SphereEventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    private void OnGUI()
    {
        // Create a GUI Button at the specified Rect (ie Rectangle)
        // and run the nested code if it is clicked.
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click Me"))
        {
            if (OnClicked != null)
                OnClicked();
        }
    }
}
