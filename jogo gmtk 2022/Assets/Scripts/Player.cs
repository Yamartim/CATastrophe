using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    // movement
    private float moveSpeed = 5;
    private Vector2 moveInput;

    // shooting
    [SerializeField] private GameObject bullet;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
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
             Shoot();
        }

    }
    
    private void FixedUpdate()
    {
        rb.velocity = moveInput * moveSpeed; // * Time.deltaTime;
    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

}
