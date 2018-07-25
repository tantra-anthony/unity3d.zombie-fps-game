using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    
    private bool called = false;
    private Rigidbody rigidBody;

    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnDispatchHelicopter() {
        if (!called) {
            called = true;
            rigidBody.velocity = new Vector3(0f, 0f, 50f);
        }
    }
}
