using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private ArmaScript arma;
    private GameManager gameManager;

    // movement
    private float moveSpeed = 5;
    private Vector2 moveInput;

    // stats
    public float hp = 10;
    public float maxHp = 10;

    // score
    public int score;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        arma = GetComponentInChildren<ArmaScript>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        // movement input
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        moveInput.Normalize(); // makes diagonal movement more natural

        // Shotting
        if (Input.GetMouseButtonDown(0))
        {
             arma.Shoot();
        }

    }
    
    private void FixedUpdate()
    {
        rb.velocity = moveInput * moveSpeed; // * Time.deltaTime;
    }

    public void TakeDamage()
    {
        hp--;
        if(hp <= 0)
        {
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            TakeDamage();
        }
    }

    public void ScoreUp()
    {
        score++;
    }
}
