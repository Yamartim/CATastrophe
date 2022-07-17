using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D12 : Dado
{

        public override int lados {get{return 12;}}
    public override TipoDado tipo {get{return TipoDado.d12;}}

    void Awake()
    {
        
    }
    
}