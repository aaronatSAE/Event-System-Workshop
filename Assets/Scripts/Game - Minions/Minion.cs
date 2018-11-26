using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Improve this!
public class Minion : MonoBehaviour
{
    public GameObject explosionPrefab;



    void Update()
    {


        transform.LookAt(Vector3.zero);
        // Improve this!
        transform.Translate(new Vector3(0,0,1) * Time.deltaTime, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(BecomeDead());
        }
        else if(collision.gameObject.tag == "Bullet")
        {
            StartCoroutine(BecomeDead());
        }
    }

    IEnumerator BecomeDead()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
        yield return new WaitForSeconds(0.1f);
        Destroy(explosion);
    }



}
