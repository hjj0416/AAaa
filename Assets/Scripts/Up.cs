using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Up : MonoBehaviour {

    public int velocity = 1;
    public bool ZTSwitch=true;
    public GameObject Center;
    public LineRenderer line;
    public GameObject music;
	// Use this for initialization
	void Start () {
        music = GameObject.Find("Music");
        Center = GameObject.Find("Center");
        line = transform.GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(ZTSwitch)
        {
            transform.Translate(0, velocity * Time.deltaTime, 0);
            if(transform.position.y>=-2.5f)
            {
                transform.position = new Vector3(0, -2.5f, 0);
                transform.SetParent(Center.transform);
                music.GetComponent<Music>().MusicPlay1();
                ZTSwitch = false;
            }
        }
        else
        {
            line.SetPosition(1, transform.position);
        }
       
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Ball")
        {
            music.GetComponent<Music>().MusicPlay2();
            Center.GetComponent<Turn>().OnStop();
            Invoke("OnOver",1.0f);
        }
    }

    private void OnOver()
    {
        SceneManager.LoadScene(0);
    }
}
