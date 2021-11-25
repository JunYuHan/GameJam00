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
	bool ChooseNumber; //PULL�� �������� ���ڰ� �Ѱ��� ������ �Ϸ��� ����
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

	public void OnClick() //�˾�â�� ���ڍ�
	{
		CardNumber = Random.Range(0, 14);
		NumberText.text = "" + CardNumber.ToString();
		ChooseNumber = false;
	}
}
