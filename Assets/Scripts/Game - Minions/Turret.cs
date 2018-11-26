using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Improve this!
public class Turret : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject bulletPrefab;

    private void OnEnable()
    {
        MinionsGameManager.OnMouseClick += Shoot;
    }

    private void OnDisable()
    {
        MinionsGameManager.OnMouseClick -= Shoot;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
    
    public void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().AddForce(firePoint.transform.forward * 200f);
    }
}
