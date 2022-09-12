using System;
using Leopotam.EcsLite;
using Scenes;
using UnityEngine;

public class ECSWorld : MonoBehaviour {
    public EcsWorld _world;
    public EcsSystems _systems;

    private void Awake() {
        Init();
    }

    // Initialization of ecs world and systems.
    void Init() {
        SharedData sharedData = new SharedData {
            MouseDown = false
        };

        _world = new EcsWorld();
        _systems = new EcsSystems(_world, sharedData)
        .Add(new MovementSystem())
        .Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem());

        _systems.Init();
    }

    // Engine update loop.
    private void Update() {
        _systems?.Run();
    }


    private void OnDestroy() {
        Destroy();
    }

    // Cleanup.
    void Destroy() {
        if (_systems != null){
            _systems.Destroy();
            _systems = null;
        }

        if (_world != null){
            _world.Destroy();
            _world = null;
        }
    }
}