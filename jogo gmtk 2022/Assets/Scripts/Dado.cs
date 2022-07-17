using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Dado : MonoBehaviour
{
    public abstract int lados {get;}
    public abstract TipoDado tipo {get;}
    public int valor;
    TMP_Text valor_txt;


    public void PosRolar(int rolado) {
        valor = rolado;
        valor_txt = GetComponentInChildren<TMP_Text>();
        valor_txt.text = rolado.ToString(); 
    }



    void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.gameObject.tag == "Enemy")
        {
            coll.gameObject.GetComponent<Enemy>().TakeDamage(valor);
        }
        Destroy(gameObject, 2f);
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }


}

