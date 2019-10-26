using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    private int z=3;
    
    // Use this for initialization
	void Start () {
        offset = transform.position-player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
	//Add this important comment
}
