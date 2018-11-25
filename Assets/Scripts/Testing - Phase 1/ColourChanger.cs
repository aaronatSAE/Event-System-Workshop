﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public Renderer rend;
    // Whenever you subscribe a method to an event,
    // you must always have a corresponding unsubscribe.
    // Failing to do so can result in errors or memory leaks.

    private void Start()
    {
        // Assign the renderer if it hasn't been assigned yet.
        if (rend == false)
        {
            rend = GetComponent<Renderer>();
        }
    }

    // Called whenever the attached object is created or enabled in a scene.
    private void OnEnable()
    {
        // Subscribe Teleport to the OnClicked event on the EventManager script.
        // This ensures that whenever the event occurs, Teleport is called.
        SphereEventManager.OnClicked += ChangeColour;
    }

    // Called whenever the attached object is disabled or destroyed in a scene.
    private void OnDisable()
    {
        // Unsubscribe Teleport from the OnClicked event.
        // This ensures Teleport is no longer called when OnClicked occurs.
        SphereEventManager.OnClicked -= ChangeColour;
    }

    // Change the attached object's colour.
    void ChangeColour()
    {
        Color newColour = new Color(Random.value, Random.value, Random.value);
        rend.material.color = newColour;
    }
}
