using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTube : MonoBehaviour
{
    private DadoFactory df;

    [SerializeField]private int tam_fila = 5;
    private Queue<GameObject> fila_dados;




    // Start is called before the first frame update
    void Start()
    {
        df = GetComponent<DadoFactory>();
        fila_dados = new Queue<GameObject>();
        EncherFilaRand();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddDado(TipoDado td)
    {
        fila_dados.Enqueue(df.GetDado(td));

    }

    public GameObject TiraDado()
    {
        if(fila_dados.Count == 0)
            return null;
        return fila_dados.Dequeue();
    }

    void EncherFilaRand()
    {
        TipoDado rand;
        while(fila_dados.Count < tam_fila)
        {
            rand = (TipoDado)Random.Range(0, 5);
            fila_dados.Enqueue(df.GetDado(rand));

        }
    }

    void ChacoalharDados()
    {
        foreach(GameObject dado in fila_dados)
        {
            dado.GetComponent<Dado>().RolaValor();
        }
    }

}


