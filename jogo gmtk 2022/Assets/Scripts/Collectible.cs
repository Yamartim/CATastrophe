using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private DadoFactory df;
    DiceTube diceTubeScript;
    AudioSource reloadSFX;

    void Start(){
        diceTubeScript = FindObjectOfType<Player>().gameObject.GetComponentInChildren<DiceTube>();
        df = FindObjectOfType<Player>().gameObject.GetComponentInChildren<DadoFactory>();
        reloadSFX = FindObjectOfType<Player>().gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && diceTubeScript.GetDados().Length < 5)
        {
            reloadSFX.pitch = Random.Range(0.8f,1.2f);
            reloadSFX.Play();
            var rand = (TipoDado)Random.Range(0, 5);
            var lmao = df.GetDado(rand).GetComponent<Dado>();
            diceTubeScript.AddDado(lmao);
            Destroy(gameObject);
        }
    }
}
