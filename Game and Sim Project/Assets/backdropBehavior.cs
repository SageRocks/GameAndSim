using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdropBehavior : MonoBehaviour {
    Vector3 tempPos;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //Vector3 tempPos;
        tempPos = transform.position;
        tempPos.x -= 0.002f;
        if (tempPos.x < -44.1537) tempPos.x = -10.0537f;
        transform.position = tempPos;
    }
}
