using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Storage : MonoBehaviour
{
    public int num;
    public bool isSum;
    public TextMeshProUGUI sumText;
    public TextMeshProUGUI difText;
    public CardScript lastCardScript;

    public void Operation()
    {
        if(isSum){
            var sum = int.Parse(sumText.text) + num;
            sumText.text  = sum.ToString();
        }else{
            var dif = int.Parse(difText.text) + num;
            difText.text = dif.ToString();
        }
    }
}
