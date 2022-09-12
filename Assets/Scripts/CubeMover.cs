using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public ECSWorld world;
    public float MoveSpeed = 0.1f;
    
    void Update() {
        SharedData sharedData = world._systems.GetShared<SharedData>();
        transform.position += new Vector3(sharedData.HorizontalMovement, sharedData.VerticalMovement, 0).normalized*MoveSpeed;
    }
}
