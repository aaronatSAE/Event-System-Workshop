using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    public GameObject firePrefab;

    /// <summary>
    /// Called whenever the attached object is created or enabled in a scene.
    /// </summary>
    private void OnEnable()
    {
        EventManager.OnSpawnFire += SpawnFire;
    }

    /// <summary>
    /// Called whenever the attached object is disabled or destroyed in a scene.
    /// </summary>
    private void OnDisable()
    {
        EventManager.OnSpawnFire -= SpawnFire;
    }
    
    void SpawnFire()
    {
        Instantiate(firePrefab, new Vector3(Random.Range(-20f, 20f), 0f, Random.Range(-8f, 40f)), Quaternion.identity);
    }
}
