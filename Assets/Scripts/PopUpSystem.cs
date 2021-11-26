using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PopUpSystem : MonoBehaviour
{
    [SerializeField] GameObject PopUp;
    [SerializeField] GameObject start;
    [SerializeField] GameObject Credit;

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
    }

    public void OnClickStartButton(bool active)
    {
        start.SetActive(active);
        Credit.SetActive(active);
    }

    public void MoveScene(string sceneName) //æ¿ ¿Ãµø
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
