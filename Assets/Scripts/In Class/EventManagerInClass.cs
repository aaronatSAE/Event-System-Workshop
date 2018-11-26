using UnityEngine;

public class EventManagerInClass : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    [SerializeField] private float timer = 1f;
    [SerializeField] private float timeReset = 1f;

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            // If something (gameobject, class, etc) is listening for "OnClicked"...
            if (OnClicked != null)
            {
                // ...broadcast OnClicked!
                OnClicked();
            }
            timer = timeReset;
        }

        //// We can use "GetMouseButtonDown" to detect a click.
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // If something (gameobject, class, etc) is listening for "OnClicked"...
        //    if (OnClicked != null)
        //    {
        //        // ...broadcast OnClicked!
        //        OnClicked();
        //    }
        //}
    }
}
