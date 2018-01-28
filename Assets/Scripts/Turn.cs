using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

    public int velocity = 1,state=1;
    public bool Switch = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Switch)
        {
            if(state==1)
            {
                transform.Rotate(0,0,-velocity*Time.deltaTime);
            }
            if(state==2)
            {
                transform.Rotate(0, 0,velocity * Time.deltaTime);
            }
        }
	}

    public void OnPlay()
    {
        Switch = true;
    }

    public void OnStop()
    {
        Switch = false;
    }
}
