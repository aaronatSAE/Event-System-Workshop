using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Improve this!
public class MinionsGameManager : MonoBehaviour
{
    public delegate void SpawnMinion();
    public static event SpawnMinion OnSpawnMinion;

    public delegate void MouseClick();
    public static event MouseClick OnMouseClick;

    // Improve this! (encapsulation)
    public float spawnTimer = 0.5f;

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            // Improve this!
            spawnTimer = 2f;

            if (OnSpawnMinion != null)
                OnSpawnMinion();
        }

        if (Input.GetMouseButton(0))
        {
            if (OnMouseClick != null)
                OnMouseClick();
        }
    }
}
