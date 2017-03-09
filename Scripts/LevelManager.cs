using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string level)
    {

        Application.LoadLevel(level);

    }

    public void quitGame()
    {

        Application.Quit();

    }

}
