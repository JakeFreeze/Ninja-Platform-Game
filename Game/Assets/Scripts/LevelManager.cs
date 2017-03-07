using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void loadLevel(string level)
    {

        //Debug.Log("Attempting to load " + level);

        Application.LoadLevel(level);

    }

    public void quitGame()
    {

        Application.Quit();

    }

}
