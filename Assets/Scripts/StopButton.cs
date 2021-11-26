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
	public void StopButtonClick(bool active) //팝업창 떳을 때 버튼 안보이게
	{
		StopPopUp.SetActive(active);
	}
	public void OnClickStop()
	{
		PullCard pullCard = GameObject.Find("Pull").GetComponent<PullCard>();
		PlusNumber.text = pullCard.sum[pullCard.Now_Sum_Number].ToString();
		pullCard.Now_Sum_Number++;
		//PlusNumber.text = "" + PlusNumber.ToString();
	}
}
