using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DadoFactory : MonoBehaviour
{
    
    [SerializeField] private GameObject d4prefab;
    [SerializeField] private GameObject d6prefab;
    [SerializeField] private GameObject d8prefab;
    [SerializeField] private GameObject d10prefab;
    [SerializeField] private GameObject d12prefab;
    [SerializeField] private GameObject d20prefab;

    public GameObject GetDado(TipoDado td)
    {
        switch (td)
        {
            case TipoDado.d4:
                return d4prefab;
            case TipoDado.d6:
                return d6prefab;
            case TipoDado.d8:
                return d8prefab;
            case TipoDado.d10:
                return d10prefab;
            case TipoDado.d12:
                return d12prefab;
            case TipoDado.d20:
                return d20prefab;
            default:
                return null;
        }
    }


}

public enum TipoDado
{
    d4,
    d6,
    d8,
    d10,
    d12,
    d20
}





