﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Vector3 tempPos;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        tempPos = transform.position;
        tempPos.x += 5f;
        transform.position = tempPos;
	}
}
