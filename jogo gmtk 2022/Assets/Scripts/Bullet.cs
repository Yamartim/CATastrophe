using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 10;

    Vector3 screenPoint;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.velocity = (screenPoint - transform.position).normalized*moveSpeed;
        //rb.velocity = transform.right * moveSpeed;

    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
