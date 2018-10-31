using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainUI : MonoBehaviour
{
    public Camera titleCamera;
    public Camera gameScreenCamera;
    /*string[] unloadedSounds = {
            "Select", "newHover"
        };
    AudioSource[] audioSources;
    AudioClip[] audioClips;
    AudioSource[] testSource;
    */
    // Use this for initialization
    void Start()
    {
        /*for (int i = 0; i < unloadedSounds.Length; i++) // Load Clips
        {
            audioSources[i] = (AudioSource)gameObject.AddComponent<AudioSource>();
            audioClips[i] = (AudioClip)Resources.Load(unloadedSounds[i]);
            audioSources[i].clip = audioClips[i];

            int length = unloadedSounds.Length;

            testSource = new AudioSource[length];

            //arrayGen0Lengths[i] = arrayGen0Clips[i].length;
        }*/
    }

    // Update is called once per frame

    public void hoverBtn(GameObject btn)
    {
        btn.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 1);
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
        //audioSources[0].Play();
    }

    public void exitBtn(GameObject btn)
    {
        btn.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
    }

    /*public void play() {
        //AudioClip source = (AudioClip)Resources.Load("Select");
        //AudioSource sound = (AudioSource)Resources.Load("newHover");//GetComponent<AudioSource>();
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
        //audioSources[1].Play();
    }*/

    public void exit()
    {
        Application.Quit();
    }

    public void play()
    {
        //AudioClip source = (AudioClip)Resources.Load("Select");
        //AudioSource sound = (AudioSource)Resources.Load("newHover");//GetComponent<AudioSource>();
        //audioSources[1].Play();
        SceneManager.LoadScene("Main");
    }

    public void clickRoverCollect()
    {
        SceneManager.LoadScene("OreCollection");
    }

    public void hoverRover(GameObject btn) {
        btn.GetComponent<Transform>().localScale = new Vector3(1.3f, 1.1f, 1);
    }

    public void exitsRover(GameObject btn) {
        btn.GetComponent<Transform>().localScale = new Vector3(1.18f, 1, 1);
    }
}