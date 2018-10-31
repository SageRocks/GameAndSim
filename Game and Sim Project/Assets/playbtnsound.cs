using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playbtnsound : MonoBehaviour {
    void OnMouseOver()
    {
        AudioSource sound = gameObject.GetComponent<AudioSource>();
        sound.Play();
    }
}
