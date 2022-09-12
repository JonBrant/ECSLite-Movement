using Leopotam.EcsLite;
using UnityEngine;

namespace Scenes {
    public class MovementSystem : IEcsRunSystem{
        public void Run(EcsSystems systems) {
            SharedData shared = systems.GetShared<SharedData> ();
            Debug.Log($"{nameof(MovementSystem)}.{nameof(Run)}() - MouseDown: {shared.MouseDown}");
        }
    }
}