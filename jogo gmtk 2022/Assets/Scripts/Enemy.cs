using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Player player;

    private float chaseRange = 7f;
    private float moveSpeed = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= chaseRange)
        {
            Chase();
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

    }

    private void Chase()
    {
        rb.velocity = (player.transform.position - transform.position).normalized * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            player.ScoreUp();
        }
    }

}
