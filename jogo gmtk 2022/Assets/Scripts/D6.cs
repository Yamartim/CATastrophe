using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class D6 : Dado
{

    public override int lados {get{return 6;}}
    public override TipoDado tipo {get{return TipoDado.d6;}}

    void Awake()
    {

    }

}
