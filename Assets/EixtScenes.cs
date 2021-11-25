using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EixtScenes : MonoBehaviour
{
    public void SceneQuit()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }
    public void GameQuit()
    {
        Application.Quit();
    }
}
