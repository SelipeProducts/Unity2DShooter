﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firepoint;
    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
	}
    void Shoot() {
        //shooting logic
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
