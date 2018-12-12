using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(speed, 0f);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")    //All bullets get destroyed if they hit a wall
        {
            Destroy(gameObject);
            return;
        }
        if (other.tag == "Enemy" && tag == "PlayerBullet") //Player bullets destroy enemies (and they get destryoed)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }
        if (other.tag == "Player" && tag == "EnemyBullet") //Enemy bullets destroy the player
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }
        if (other.tag == "Enemy" && tag == "EnemyBullet") //Enemy bullets get destroyed if they hit an enemy
        {
            Destroy(gameObject);
            return;
        }

        //NOTE: The if sentences can be combined (when the inside block is the same). For simplicity they are written seperately.
    }
}
