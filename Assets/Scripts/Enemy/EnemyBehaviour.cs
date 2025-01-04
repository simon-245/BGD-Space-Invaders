using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int value = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collided");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered");

        // The name of the clone in the game will be Projectile(Clone) not Projectile
        // So checking the name doesn't work
        //if (collision.name == "Projectile")

        // Instead, check the tag
        if (collision.tag == "PlayerProjectile")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint(value);
        }
    }
}
