using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour {

    public Text levelText;
    public int Level=1;
    public GameObject[] levelObject;
	// Use this for initialization
	void Start () {
        Level = PlayerPrefs.GetInt("x");
        if (Level > 3||Level<=0)
            Level = 1;
        GameObject levelPrefab = Instantiate(levelObject[Level-1]) as GameObject;
        levelPrefab.transform.parent=GameObject.Find("Center").transform;
		if(PlayerPrefs.HasKey("x")==false)
        {
            PlayerPrefs.SetInt("x",1);
        }
        levelText.text = Level.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnWin()
    {
        Level++;
        PlayerPrefs.SetInt("x", Level);
        SceneManager.LoadScene(0);

    }
}
