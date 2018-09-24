using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Light myLight;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("Space"))
        {
            myLight.enabled = true;
        }
        if(Input.GetKeyUp ("Space"))
        {
            myLight.enabled = false;
        }
	}
}
