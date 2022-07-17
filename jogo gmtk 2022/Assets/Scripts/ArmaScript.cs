using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour
{
    [SerializeField] float shootforce = 1000;
    //[SerializeField] private GameObject bullet;
    private DiceTube tubo;
    private DadoFactory df;

    

    // Start is called before the first frame update
    void Start()
    {
        tubo = GetComponent<DiceTube>();
        df = GetComponent<DadoFactory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Shoot()
    {
        Dado dado = tubo.TiraDado();
        if (dado == null)
        {
            Debug.Log("sem munição!");
            return;
        }
        GameObject tiro = Instantiate(df.GetDado(dado.tipo), transform.position, Quaternion.identity);

        Rigidbody2D dadorb = tiro.GetComponent<Rigidbody2D>();
        Vector2 dir = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        //dadorb.AddForce(dir.normalized*shootforce, ForceMode2D.Impulse);
        dadorb.velocity = dir.normalized*shootforce;


    }

}
