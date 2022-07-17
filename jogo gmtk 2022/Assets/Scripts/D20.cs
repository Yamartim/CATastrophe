using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class D20 : Dado
{

    public override int lados {get{return 20;}}
    public override TipoDado tipo {get{return TipoDado.d20;}}

    void Awake()
    {
        
    }
    
}