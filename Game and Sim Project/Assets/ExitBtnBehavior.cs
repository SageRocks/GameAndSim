using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBtnBehavior : MonoBehaviour {

    // Use this for initialization
    void OnMouseOver()
    {
        GetComponent<Transform>().localScale = new Vector3(350f, 350f, 1);
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        GetComponent<Transform>().localScale = new Vector3(300f, 300f, 1);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Application.Quit();
    }
}