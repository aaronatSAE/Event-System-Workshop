using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void MouseClick();
    public static event MouseClick OnMouseClick;

    public delegate void SpawnFire();
    public static event SpawnFire OnSpawnFire;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (OnMouseClick != null)
                OnMouseClick();
        }
    }

    public static void MethodSpawnFire()
    {
        if (OnSpawnFire != null)
            OnSpawnFire();
    }
}
