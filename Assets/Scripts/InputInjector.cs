using System;
using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEngine;

public class InputInjector : MonoBehaviour {
    public ECSWorld world;

    private void Update() {
        Debug.Assert(world != null);
        Debug.Assert(world._systems != null);
        SharedData sharedData = world._systems.GetShared<SharedData>();
        
        sharedData.MouseDown = Input.GetMouseButton(0);
        sharedData.HorizontalMovement = Input.GetAxisRaw("Horizontal");
        sharedData.VerticalMovement = Input.GetAxisRaw("Vertical");
    }
}