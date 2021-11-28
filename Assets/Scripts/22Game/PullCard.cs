using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PullCard : MonoBehaviour
{
	public GameObject P1_Turn;
	public GameObject P2_Turn;
	public GameObject P1_WinPopUp;
	public GameObject P2_WinPopUp;
	public GameObject EndPopUp;
	public Text NumberText1;
	public Text NumberText2;
	public GameObject Image; //메뉴화면으로 돌아갈때 다른거 못 누르게하기 위해서
	private bool IsClear;
	private int PlayerIndex; //0,1(0이면 P1/1이면 P2)

	private int CardNumber; //뽑은 수
	private int P1_RemainNumber; // 100에서 CardNumber 뺀 수
	private int P2_RemainNumber; // 100에서 CardNumber 뺀 수
	public int[] sum = new int[5];   // 배열은 배열 크기를 정해둬야해서 안좋은게 있지만 효율적임 리스트보다 주소 할당을 적게 받아서 메모리가 덜 먹음
									 //public List<int> sum = new List<int>();   // List 리스트는 배열 크기 안정해두고 List.Add로 계속 추가 가능, *(List.Remove, List.RemoveAt, List.RemoveAtAll로 삭제도 가능)
	bool ChooseNumber; //PULL를 눌렀을때 숫자가 한개씩 나오게 하려는 변수
	void Start()
	{
		IsClear = false;
		ChooseNumber = true;
		P1_RemainNumber = 100;
		P2_RemainNumber = 100;
		NumberText1.text = P1_RemainNumber.ToString(); // P1의 숫자가 텍스트에 점수뜨기 위해 
		NumberText2.text = P2_RemainNumber.ToString(); // P2의 숫자가 텍스트에 점수뜨기 위해 
	}
	// Update is called once per frame
	void Update()
	{
		Image.SetActive(IsClear);

		switch (PlayerIndex)
		{
			case 0:
				P1_Turn.SetActive(true);
				P2_Turn.SetActive(false);
				break;

			case 1:
				P1_Turn.SetActive(false);
				P2_Turn.SetActive(true);
				break;
		}



	}
	//public void PullButtonClick(bool active)
	//{
	//	NumberCardPopUp.SetActive(active);
	//}

	public void OnClickPull() //팝업창에 숫자뜲
	{
		CardNumber = Random.Range(1, 14); // 0~14

		switch (PlayerIndex)
		{
			case 0:
				P1_RemainNumber -= CardNumber;
				NumberText1.text = string.Format("{0}", P1_RemainNumber.ToString());
				PlayerIndex = 1;
				break;

			case 1:
				P2_RemainNumber -= CardNumber;
				NumberText2.text = string.Format("{0}", P2_RemainNumber.ToString());
				PlayerIndex = 0;
				break;
		}
		if (P2_RemainNumber == 22 || P1_RemainNumber < 22)
		{
			P2_WinPopUp.SetActive(true);
			IsClear = true;
			EndPopUp.SetActive(true);
		}

		if (P1_RemainNumber == 22 || P2_RemainNumber < 22)
		{
			P1_WinPopUp.SetActive(true);
			IsClear = true;
			EndPopUp.SetActive(true);
		}

		ChooseNumber = false;
	}

}
