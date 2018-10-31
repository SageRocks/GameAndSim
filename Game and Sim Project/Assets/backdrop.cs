using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tempPos;
        tempPos = transform.position;
        tempPos.x -= 0.2f;
        if (tempPos.x < -1109) tempPos.x = 1241;
        transform.position = tempPos;
    }
}
