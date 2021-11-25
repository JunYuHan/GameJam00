using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PullCard : MonoBehaviour
{
	public GameObject NumberCardPopUp;
	public Text NumberText;
	private int CardNumber;
	bool ChooseNumber; //PULL를 눌렀을때 숫자가 한개씩 나오게 하려는 변수
	void Start()
	{
		ChooseNumber = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (EventSystem.current.IsPointerOverGameObject() == false)
			{
				NumberCardPopUp.SetActive(false);
				//PullButtonClick(true);
			}
		}
		
	}	
	public void PullButtonClick(bool active)
	{
		NumberCardPopUp.SetActive(active);
	}

	public void OnClick() //팝업창에 숫자뜲
	{
		CardNumber = Random.Range(0, 14);
		NumberText.text = "" + CardNumber.ToString();
		ChooseNumber = false;
	}
}
