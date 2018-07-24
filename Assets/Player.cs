﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints; //parent of spawn points
    public bool respawn;

    private Transform[] spawnPoints;
    private bool lastToggle = false;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoints.Length);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != respawn) {
            Respawn();
            respawn = false;
        } else {
            lastToggle = respawn;
        }
	}

    private void Respawn() {
        int i = Random.Range(1, spawnPoints.Length + 1);
        transform.position = spawnPoints[i].transform.position;
    }
}
