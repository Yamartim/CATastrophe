using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tuboUI : MonoBehaviour
{

    [SerializeField] private Image[] slots = new Image[5];
    [SerializeField] private Sprite d4sprt;
    [SerializeField] private Sprite d6sprt;
    [SerializeField] private Sprite d8sprt;
    [SerializeField] private Sprite d10sprt;
    [SerializeField] private Sprite d12sprt;
    [SerializeField] private Sprite d20sprt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefreshDados(Dado[] qd)
    {
        for(int i = 0; i < 5; i++)
        {
            if(i < qd.Length)
            {

                slots[i].color = Color.white;

                switch(qd[i].tipo)
                {
                    case TipoDado.d4:
                        slots[i].sprite = d4sprt;
                        break;
                    case TipoDado.d6:
                        slots[i].sprite = d6sprt;
                        break;
                    case TipoDado.d8:
                        slots[i].sprite = d8sprt;
                        break;
                    case TipoDado.d10:
                        slots[i].sprite = d10sprt;
                        break;
                    case TipoDado.d12:
                        slots[i].sprite = d12sprt;
                        break;
                    case TipoDado.d20:
                        slots[i].sprite = d20sprt;
                        break;
                    default:
                        slots[i].sprite = d20sprt;
                        break;
                }
            }else slots[i].color = Color.clear;
        }
    }

}
