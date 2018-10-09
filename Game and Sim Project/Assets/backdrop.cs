using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdrop : MonoBehaviour {

    Vector2 tempPos;

	// Use this for initialization
	void Start () {
        tempPos = new Vector2 (5f, 6f);
    }
	
	// Update is called once per frame
	void Update () {
        /*tempPos = transform.position;
        tempPos.x += 5f;
        transform.position = tempPos;*/
        tempPos = new Vector2(tempPos.x + 1, 6f);
        Debug.Log(tempPos.x);
    }
}
