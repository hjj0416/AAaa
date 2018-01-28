using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrefabBall : MonoBehaviour {

    public GameObject ball;
    public int number = 20;
    public GameObject[] ball123;
    public bool NSwitch=true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(number>0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject Bullet = Instantiate(ball) as GameObject;
                number--;
                Debug.Log(number);
            }
        }else
        {
            //if(NSwitch)
            //{
                Invoke("OnWinWin", 1.5f);
            //    NSwitch = false;
            //}

        }
        for(int i=1;i<=3;i++)
        {
            GameObject.Find("T"+i).GetComponent<Text>().text= (number-i+1).ToString();
        }
        if(number<=2)
        {
            if(GameObject.Find("Ball" + number))
                GameObject.Find("Ball" + number).SetActive(false);

        }
    }

    public void OnWinWin()
    {
        transform.GetComponent<LevelUp>().OnWin();
    }
}
