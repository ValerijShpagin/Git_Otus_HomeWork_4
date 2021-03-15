using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private Systems _systems;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        _systems = new Systems()
                .Add(new PrefabInstantiateSystem(_contexts))
                .Add(new InitializeGameSystem(_contexts))
                .Add(new TransformApplySystem(_contexts))
                
            ;
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }

    private void OnDestroy()
    {
        _systems.TearDown();
    }
}
