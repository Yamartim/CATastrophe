using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Dado : MonoBehaviour
{
    public abstract int lados {get;}
    private int valor;
    TMP_Text valor_txt;

    private void Start() {

        valor_txt = GetComponentInChildren<TMP_Text>();
        RolaValor();
        valor_txt.text = valor.ToString();
        
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

