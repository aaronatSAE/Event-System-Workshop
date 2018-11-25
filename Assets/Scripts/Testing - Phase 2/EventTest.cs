using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EventTest : MonoBehaviour
{

    private UnityAction someListener;

    void Awake()
    {
        someListener = new UnityAction(SomeFunction);
    }

    void OnEnable()
    {
        EventManagerTutorialTester.StartListening("test", someListener);
        EventManagerTutorialTester.StartListening("Spawn", SomeOtherFunction);
        EventManagerTutorialTester.StartListening("Destroy", SomeThirdFunction);
    }

    void OnDisable()
    {
        EventManagerTutorialTester.StopListening("test", someListener);
        EventManagerTutorialTester.StopListening("Spawn", SomeOtherFunction);
        EventManagerTutorialTester.StopListening("Destroy", SomeThirdFunction);
    }

    void SomeFunction()
    {
        Debug.Log("Some Function was called!");
    }

    void SomeOtherFunction()
    {
        Debug.Log("Some Other Function was called!");
    }

    void SomeThirdFunction()
    {
        Debug.Log("Some Third Function was called!");
    }
}
