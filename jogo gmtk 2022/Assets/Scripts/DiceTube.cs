using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTube : MonoBehaviour
{
    private DadoFactory df;
    [SerializeField] private tuboUI tUI;

    [SerializeField]private int tam_fila = 5;
    private Queue<Dado> fila_dados;




    // Start is called before the first frame update
    void Start()
    {
        df = GetComponent<DadoFactory>();

        fila_dados = new Queue<Dado>();
        EncherFilaRand();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddDado(Dado d)
    {
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

    void EncherFilaRand()
    {
        TipoDado rand;
        while(fila_dados.Count < tam_fila)
        {
            rand = (TipoDado)Random.Range(0, 5);
            fila_dados.Enqueue(df.GetDado(rand).GetComponent<Dado>());

        }
        tUI.RefreshDados(GetDados());
    }

    void ChacoalharDados()
    {
        foreach(Dado d in fila_dados)
        {
            d.RolaValor();
        }
        tUI.RefreshDados(GetDados());
    }

    Dado[] GetDados()
    {
        return fila_dados.ToArray();
    }

}


