
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPlayer2 : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            
            Shoot();
        }
    }
    void Shoot()
    {
        //shooting logic
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Debug.Log("instantiate");
    }
}
