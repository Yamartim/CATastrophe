using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 10f;

    Vector3 screenPoint;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //rb.AddForce((screenPoint - transform.position).normalized*moveSpeed, ForceMode2D.Impulse);
        rb.velocity = ((Vector2)screenPoint - (Vector2)transform.position).normalized*moveSpeed;
        //rb.velocity = transform.right * moveSpeed;
        //Debug.Log((screenPoint - transform.position));

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
