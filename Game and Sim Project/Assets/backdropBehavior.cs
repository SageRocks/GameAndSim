using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdropBehavior : MonoBehaviour {
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 tempPos;
        tempPos = transform.position;tempPos.x -= 3f;
        if(tempPos.x < -3440) tempPos.x = 3389;
        transform.position = tempPos;
    }
}
