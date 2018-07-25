﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    public float timeSinceLastTrigger = 0f;

    private bool foundClearArea = false;
	
	// Update is called once per frame
	void Update () {
        timeSinceLastTrigger += Time.deltaTime;
        //suppress heli call at least 10 seconds
        if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea) {
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }
	}

    private void OnTriggerStay(Collider other) {
        if (other.tag != "Player") {
            timeSinceLastTrigger = 0f;
        }
    }
}
