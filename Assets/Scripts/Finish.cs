using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public string destMapName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.Instance.player.gameObject == other.transform.parent.gameObject)
        {
            GameManager.Instance.MapSwitch(destMapName);
        }
    }
}
