using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour
{
    private AudioSource shootAudio;
    private ParticleSystem shootParticle;
    [SerializeField] GameObject particleTransform;
    [SerializeField] float shootforce = 1000;
    //[SerializeField] private GameObject bullet;
    private DiceTube tubo;
    private DadoFactory df;

    

    // Start is called before the first frame update
    void Start()
    {
        tubo = GetComponent<DiceTube>();
        df = GetComponent<DadoFactory>();
        shootAudio = GetComponent<AudioSource>();
        shootParticle = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Shoot(bool isFlipped)
    {
        if(isFlipped){
            particleTransform.transform.rotation = new Quaternion (0, 0, 0.7071068f, 0.7071068f);
        }else{
            particleTransform.transform.rotation = new Quaternion (0, 0, -0.7071068f, 0.7071068f);
        }
        Dado dado = tubo.TiraDado();
        if (dado == null)
        {
            Debug.Log("sem munição!");
            return;
        }else{
            shootAudio.pitch = Random.Range(0.8f,1.2f);
            shootAudio.Play();
            shootParticle.Play();
        }
        GameObject tiro = Instantiate(df.GetDado(dado.tipo), transform.position, Quaternion.identity);

        Rigidbody2D dadorb = tiro.GetComponent<Rigidbody2D>();
        Vector2 dir = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        //dadorb.AddForce(dir.normalized*shootforce, ForceMode2D.Impulse);
        dadorb.velocity = dir.normalized*shootforce;


    }

}
