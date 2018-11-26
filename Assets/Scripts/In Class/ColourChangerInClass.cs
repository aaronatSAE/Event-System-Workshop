using UnityEngine;

public class ColourChangerInClass : MonoBehaviour
{
    private void OnEnable()
    {
        // += will SUBSCRIBE this gameobject to an event broadcast.
        EventManagerInClass.OnClicked += ChangeColour;
    }

    private void OnDisable()
    {
        // We also need to UNSUBSCRIBE.
        // The operator to do so is -=
        EventManagerInClass.OnClicked -= ChangeColour;
    }

    void ChangeColour()
    {
        GetComponent<Renderer>().material.color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f));
    }
}
