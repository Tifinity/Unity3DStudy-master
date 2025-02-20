﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCollide : MonoBehaviour {
    public int sign = 0;
    private FirstSceneController sceneController;

    private void Start() {
        sceneController = SSDirector.GetInstance().CurrentScenceController as FirstSceneController;
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player") {
            sceneController.playerSign = sign;
        }
    }
}
