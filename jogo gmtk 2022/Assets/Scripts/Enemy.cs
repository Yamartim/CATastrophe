using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Player player;

    private float chaseRange = 7f;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private int hp;
    [SerializeField] private int maxhp = 10;
    

    private void Start()
    {
        hp = maxhp;
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

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if(hp <= 0)
        {
            Destroy(gameObject);
            player.ScoreUp(1);
        }
    }

/*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            Destroy(collision.gameObject);
            
            player.ScoreUp(1);
        }
    }
*/
}
