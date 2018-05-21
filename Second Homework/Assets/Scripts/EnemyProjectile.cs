using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour {
    public float speed = 6f;
    public int health = 100;
    // Use this for initialization
    void Start()
    {
        var Rb = GetComponent<Rigidbody>();
        Rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerShip")
        {
            health -= 10;
            if (health == 0)
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
