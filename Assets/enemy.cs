using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    //public int health = 100;
    public GameObject deathEffect;

    //gameObject.getComponent<MoveSpeed...cs>().speed speed is instance variable
    [System.Serializable]
    public class EnemyStats {
        public int maxHealth = 100;
        public float startPercentHelath = 1f;   //changes start health of enemy

        private int _curHealth;
        public int curHealth {
            get { return _curHealth; }
            //set { _curHealth = value; }
            set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
        }
        public void init() {
            curHealth = maxHealth;// * (int) startPercentHelath;
        }
    }

    public EnemyStats stats = new EnemyStats();

    [Header("Optional")]
    [SerializeField]
    private StatusIndicator statusIndicator;

    public void TakeDamege(int damage) {
        stats.curHealth -= damage;
        if (stats.curHealth <= 0) {
            Die();
        }
        if (statusIndicator != null)
        {
            statusIndicator.setHealth(stats.curHealth, stats.maxHealth);
        }
    }
    void Die() {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
        stats = new EnemyStats();
        stats.init();

        if (statusIndicator != null) {
            statusIndicator.setHealth(stats.curHealth, stats.maxHealth);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
