using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayerSystem : InitializeGameSystem
{
    private Contexts _contexts;
    
    public InitializePlayerSystem(Contexts contexts) : base(contexts)
    {
        _contexts = contexts;
    }
    
    
}
