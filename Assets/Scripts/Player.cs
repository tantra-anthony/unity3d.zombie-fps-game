using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints; //parent of spawn points
    public bool respawn;
    public GameObject landingAreaPrefab;

    private Transform[] spawnPoints;
    private bool lastToggle = false;
    private AudioSource innerVoice;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        Respawn();
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

    private void OnFindClearArea() {
        Invoke("DropFlare", 3f);
    }

    private void DropFlare() {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }
}
