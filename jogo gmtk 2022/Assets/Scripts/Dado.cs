using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dado : MonoBehaviour
{
    protected int lados;
    private int valor;

    // Start is called before the first frame update
    void Start()
    {
        RolaValor();
    }

    public void RolaValor()
    {
        valor = Random.Range(1, lados);
    }

    void OnCollisionEnter2D(Collision2D coll) 
    {
        Destroy(gameObject, 2f);
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

}

