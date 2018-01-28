using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    public AudioClip music1;
    public AudioClip music2;
    public AudioSource AudioSource;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MusicPlay1()
    {
        AudioSource.clip = music1;
        AudioSource.Play();
    }

    public void MusicPlay2()
    {
        AudioSource.clip = music2;
        AudioSource.Play();
    }

}
