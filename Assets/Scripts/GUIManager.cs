using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour {

    public GameObject mainMenu;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void GameStart()
    {
        GameManager.Instance.LoadFirstMap();
        mainMenu.SetActive(false);
    }
}
