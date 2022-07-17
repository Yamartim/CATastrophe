using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D8 : Dado
{
    public override int lados {get{return 8;}}
    public override TipoDado tipo {get{return TipoDado.d8;}}

    void Awake()
    {

    }
    
}
