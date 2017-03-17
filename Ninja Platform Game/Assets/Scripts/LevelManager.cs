using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public string manualLevel;
	public GameObject target;
	public int whatDo;

	public void loadLevel(string level)
    {

        Application.LoadLevel(level);

    }

    public void quitGame()
    {

        Application.Quit();

    }

	void OnTriggerEnter2D(Collider2D other){
		
		target.GetComponent<TimerScript> ().EndTimer ();

		if (whatDo == 1) {
		
			loadLevel (manualLevel);
		
		}

	}

}
