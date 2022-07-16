using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private ArmaScript arma;

    // movement
    private float moveSpeed = 5;
    private Vector2 moveInput;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        arma = GetComponentInChildren<ArmaScript>();
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


}
