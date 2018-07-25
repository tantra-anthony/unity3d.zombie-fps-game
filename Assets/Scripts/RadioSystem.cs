using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();

		
	}

    private void OnMakeInitialHeliCall() {
        audioSource.clip = initialHeliCall;
        audioSource.Play();
        Invoke("InitialReply", initialHeliCall.length + 1f);
    }

    private void InitialReply() {
        audioSource.clip = initialCallReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
