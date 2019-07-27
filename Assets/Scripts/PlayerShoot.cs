using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform spawnBulletPos;
    public float fireRate;
    private float nextFire;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, spawnBulletPos.position, transform.rotation);
    }
}
