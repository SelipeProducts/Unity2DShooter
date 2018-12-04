using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public int damage = 20;
    public float speed = 200f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    

	// Use this for initialization
	void Update () {
        rb.velocity = transform.right * speed;
       
	}

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log(hitInfo.name);
        //if player
        CharacterController2D playerHit = hitInfo.GetComponent<CharacterController2D>();
        if (playerHit != null) {
            playerHit.TakeDamege(damage);
        }
        //if enemies
        enemy enemy = hitInfo.GetComponent<enemy>();
        if (enemy != null) {
            enemy.TakeDamege(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}

