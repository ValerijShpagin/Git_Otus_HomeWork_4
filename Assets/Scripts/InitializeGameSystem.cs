using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class InitializeGameSystem : IInitializeSystem
{
    private Contexts _contexts;

    public InitializeGameSystem(Contexts contexts)
    {
        _contexts = contexts;
    }


    public void Initialize()
    {
        var entity = _contexts.game.CreateEntity();
        entity.isGame = true;
        entity.AddGameState(GameState.StartGame);

    }
}
