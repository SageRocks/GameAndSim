using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtnBehavior : MonoBehaviour {

    void OnMouseEnter () {
        GetComponent<Transform>().localScale = new Vector3(350f, 350f, 1);
        AudioSource sound = gameObject.GetComponent<AudioSource>();
        sound.Play();
    }
	void OnMouseExit () {
        GetComponent<Transform>().localScale = new Vector3(300f, 300f, 1);
    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0)) //change camera
    }

    public void play()
    {
        //AudioClip source = (AudioClip)Resources.Load("Select");
        //AudioSource sound = (AudioSource)Resources.Load("newHover");//GetComponent<AudioSource>();
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
        //audioSources[1].Play();
    }
}
