using UnityEngine;

public class TeleporterInClass : MonoBehaviour
{
    [SerializeField] Vector3 bounds = new Vector3(100, 100, 100);

    private void OnEnable()
    {
        // += will SUBSCRIBE this gameobject to an event broadcast.
        EventManagerInClass.OnClicked += ChangePosition;
    }

    private void OnDisable()
    {
        // We also need to UNSUBSCRIBE.
        // The operator to do so is -=
        EventManagerInClass.OnClicked -= ChangePosition;
    }

    void ChangePosition()
    {
        transform.position = new Vector3(
        Random.Range(-bounds.x, bounds.x),
        Random.Range(-bounds.y, bounds.y),
        Random.Range(-bounds.z, bounds.z));
    }
}
