using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Test1 : MonoBehaviour
{
    private UnityAction someListener;

    private void Awake()
    {
        someListener = new UnityAction(SomeFunction);
    }

    /// <summary>
    /// Start listening here.
    /// </summary>
    private void OnEnable()
    {
        EventManagerTutorialTester.StartListening("test", someListener);
    }

    /// <summary>
    /// Stop listening here.
    /// </summary>
    private void OnDisable()
    {
        EventManagerTutorialTester.StopListening("test", someListener);
    }

    void SomeFunction()
    {
        Debug.Log("Hello World!");
    }
}
