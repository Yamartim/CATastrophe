using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTube : MonoBehaviour
{
    private DadoFactory df;
    //[SerializeField] private tuboUI tUI;
    private tuboUI tUI;

    [SerializeField]private int tam_fila = 5;
    private Queue<Dado> fila_dados;
    public int valorFinal;
    [SerializeField] AudioSource shakeSFX;




    // Start is called before the first frame update
    void Start()
    {
        df = GetComponent<DadoFactory>();
        tUI = FindObjectOfType<tuboUI>();

        fila_dados = new Queue<Dado>();
        EncherFilaRand();
    }

    public void RolaValor(Dado die)
    {
        valorFinal = Random.Range(1, die.lados);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDado(Dado d)
    {
        RolaValor(d);
        d.PosRolar(valorFinal);
        fila_dados.Enqueue(d);
        tUI.RefreshDados(GetDados());

    }

    public Dado TiraDado()
    {
        Dado dado;
        if (fila_dados.TryDequeue(out dado))
        {
            tUI.RefreshDados(GetDados());
            return dado;
        } return null;
    }

    public void EncherFilaRand()
    {
        TipoDado rand;
        while(fila_dados.Count < tam_fila)
        {
            rand = (TipoDado)Random.Range(0, 5);
            var lmao = df.GetDado(rand).GetComponent<Dado>();
            RolaValor(lmao);
            lmao.PosRolar(valorFinal);
            fila_dados.Enqueue(lmao);

        }
        tUI.RefreshDados(GetDados());
    }

    public void ChacoalharDados()
    {
        shakeSFX.pitch = Random.Range(0.5f, 1.5f);
        shakeSFX.Play();
        foreach(Dado d in fila_dados)
        {
            RolaValor(d);
            d.PosRolar(valorFinal);
        }
        tUI.RefreshDados(GetDados());
    }

    public Dado[] GetDados()
    {
        return fila_dados.ToArray();
    }

}


