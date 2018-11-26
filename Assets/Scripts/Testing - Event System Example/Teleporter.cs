using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Whenever you subscribe a method to an event,
    // you must always have a corresponding unsubscribe.
    // Failing to do so can result in errors or memory leaks.
    
    // Called whenever the attached object is created or enabled in a scene.
    private void OnEnable()
    {
        // Subscribe Teleport to the OnClicked event on the EventManager script.
        // This ensures that whenever the event occurs, Teleport is called.
        SphereEventManager.OnClicked += Teleport;
    }
    
    // Called whenever the attached object is disabled or destroyed in a scene.
    private void OnDisable()
    {
        // Unsubscribe Teleport from the OnClicked event.
        // This ensures Teleport is no longer called when OnClicked occurs.
        SphereEventManager.OnClicked -= Teleport;
    }
    
    // Move the attached object.
    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(2f, 4f);
        transform.position = pos;
    }
}
