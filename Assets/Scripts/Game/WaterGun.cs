using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    public GameObject waterPrefab;
    public static float waterLeft = 30f;
    float distance = 1000f;

    /// <summary>
    /// Called whenever the attached object is created or enabled in a scene.
    /// </summary>
    private void OnEnable()
    {
        EventManager.OnMouseClick += ShootWater;
    }

    /// <summary>
    /// Called whenever the attached object is disabled or destroyed in a scene.
    /// </summary>
    private void OnDisable()
    {
        EventManager.OnMouseClick -= ShootWater;
    }

    void ShootWater()
    {
        if(GameManager.currentState == GameManager.GameState.InGame)
        {
            waterLeft -= Time.deltaTime;

            var position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            position = Camera.main.ScreenToWorldPoint(position);

            GameObject newObject = Instantiate(waterPrefab, Camera.main.transform.position + Vector3.down * 2f, Quaternion.identity);
            newObject.transform.LookAt(position);
            newObject.GetComponent<Rigidbody>().AddForce(newObject.transform.forward * 4000f);
        }
    }
}
