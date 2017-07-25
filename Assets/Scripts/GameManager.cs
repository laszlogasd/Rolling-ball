using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Player player;
    public string currentScene;

    public static GameManager Instance;

    AsyncOperation MapLoad;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Instance = this;
        //MapSwitch("Map_1");
	}

    // Update is called once per frame
    void Update ()
    {
		
	}

    public void Restart()
    {
        GameObject start = GameObject.Find("Start");
        player.transform.position = start.transform.position;
    }

    public void MapSwitch(string destMapName)
    {
        if (currentScene != "" && currentScene != null)
        SceneManager.UnloadSceneAsync(currentScene);
        MapLoad =  SceneManager.LoadSceneAsync(destMapName, LoadSceneMode.Additive);
        currentScene = destMapName;
        StartCoroutine("Loading");
    }

    IEnumerator Loading()
    {
        while(MapLoad.isDone == false)
        {
            yield return null;
        }

        Restart();
    }

    public void LoadFirstMap()
    {
        MapSwitch("Map_1");
    }
}