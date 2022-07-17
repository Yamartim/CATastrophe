using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D10 : Dado
{
    public override int lados {get{return 10;}}
    public override TipoDado tipo {get{return TipoDado.d10;}}

    void Awake()
    {
        
    }
    
}