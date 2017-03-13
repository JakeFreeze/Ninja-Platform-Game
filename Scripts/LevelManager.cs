using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public string manualLevel;

	public void loadLevel(string level)
    {

        Application.LoadLevel(level);

    }

    public void quitGame()
    {

        Application.Quit();

    }

	void OnTriggerEnter2D(Collider2D other){

		loadLevel (manualLevel);

		Debug.Log ("xd");

	}

}
