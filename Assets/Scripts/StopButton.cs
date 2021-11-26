using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StopButton : MonoBehaviour
{
	public GameObject StopPopUp;
	public Text PlusNumber;
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
	public void OnClickStop()
	{
		PlusNumber.text = GameManager.CardNumber.ToString();
		//PlusNumber.text = "" + PlusNumber.ToString();
	}
}
