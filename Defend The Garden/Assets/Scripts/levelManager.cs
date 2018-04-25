using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    public void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void quitRequest()
    {      
        Application.Quit();
    }

    public void LoadNextLevel()
    {      
        Application.LoadLevel(Application.loadedLevel + 1);
    }

}
