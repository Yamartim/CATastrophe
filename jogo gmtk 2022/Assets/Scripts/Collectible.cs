using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private DadoFactory df;
    DiceTube diceTubeScript;

    void Start(){
        diceTubeScript = FindObjectOfType<Player>().gameObject.GetComponentInChildren<DiceTube>();
        df = FindObjectOfType<Player>().gameObject.GetComponentInChildren<DadoFactory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colidiu");
        if (collision.gameObject.tag == "Player" && diceTubeScript.GetDados().Length < 5)
        {
            var rand = (TipoDado)Random.Range(0, 5);
            var lmao = df.GetDado(rand).GetComponent<Dado>();
            diceTubeScript.AddDado(lmao);
            Destroy(gameObject);
        }
    }
}
