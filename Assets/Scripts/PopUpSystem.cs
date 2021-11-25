using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PopUpSystem : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject start;
    public GameObject Credit;
    public GameObject Exit;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)
            {
                PopUp.SetActive(false);
                OnClickStartButton(true);
            }
        }
        ExitClickPopUp();
    }

    public void OnClickStartButton(bool active)
    {
        start.SetActive(active);
        Credit.SetActive(active);
        Exit.SetActive(active);
    }

    public void MoveScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    void ExitClickPopUp()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)
            {
                Exit.SetActive(false);
                OnClickStartButton(true);
            }
        }
    }
}
