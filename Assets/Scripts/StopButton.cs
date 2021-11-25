using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopButton : MonoBehaviour
{
    public GameObject StopPopUp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)
            {
                StopPopUp.SetActive(false);
                //PullButtonClick(true);
            }
        }
    }
        public void StopButtonClick(bool active) //�˾�â ���� �� ��ư �Ⱥ��̰�
        {
            StopPopUp.SetActive(active);
        }
}
