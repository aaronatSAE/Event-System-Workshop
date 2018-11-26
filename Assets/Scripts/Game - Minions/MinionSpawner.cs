using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Improve this!
public class MinionSpawner : MonoBehaviour
{
    // Improve this! (encapsulation)
    public Vector3 anchor;

    // Improve this! (encapsulation)
    public GameObject minionPrefab;

    /// <summary>
    /// Called whenever the attached object is created or enabled in a scene.
    /// </summary>
    private void OnEnable()
    {
        MinionsGameManager.OnSpawnMinion += SpawnMinion;
        anchor = transform.position;
    }

    /// <summary>
    /// Called whenever the attached object is disabled or destroyed in a scene.
    /// </summary>
    private void OnDisable()
    {
        MinionsGameManager.OnSpawnMinion -= SpawnMinion;
    }

    // Improve this! (encapsulation)
    public void SpawnMinion()
    {
        Instantiate(minionPrefab, transform.position, Quaternion.identity);

        // Improve this!
        transform.position = anchor + transform.forward * Random.Range(-10f, 10f);
    }
}
