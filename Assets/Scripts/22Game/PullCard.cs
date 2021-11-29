using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PullCard : MonoBehaviour
{
	public static PullCard Instance { get; private set; }
	[SerializeField] private AudioSource soundPlayer;
	[SerializeField] private Button btnPull;
	[SerializeField] private Button btnBack;
	public GameObject P1_Turn;
	public GameObject P2_Turn;
	public GameObject P1_WinPopUp;
	public GameObject P2_WinPopUp;
	public GameObject EndPopUp;
	public GameObject[] P1_NumberImg;
	public GameObject[] P2_NumberImg;
	public Sprite[] Number;
	public GameObject Image; //메뉴화면으로 돌아갈때 다른거 못 누르게하기 위해서
	private bool IsClear;
	private int PlayerIndex; //0,1(0이면 P1/1이면 P2)

	private int CardNumber; //뽑은 수
	private int P1_RemainNumber; // 100에서 CardNumber 뺀 수
	private int P2_RemainNumber; // 100에서 CardNumber 뺀 수
	public int[] sum = new int[5];   // 배열은 배열 크기를 정해둬야해서 안좋은게 있지만 효율적임 리스트보다 주소 할당을 적게 받아서 메모리가 덜 먹음
									 //public List<int> sum = new List<int>();   // List 리스트는 배열 크기 안정해두고 List.Add로 계속 추가 가능, *(List.Remove, List.RemoveAt, List.RemoveAtAll로 삭제도 가능)
	bool ChooseNumber; //PULL를 눌렀을때 숫자가 한개씩 나오게 하려는 변수
	public Animator anim;
	int State = 0;
	private void Awake()
	{
		Instance = this;

	}
	void Start()
	{

		btnPull.onClick.AddListener(() =>
		{
				anim.SetTrigger("Pull ");
		});

		anim.SetBool("IsFirst", true);
		IsClear = false;
		ChooseNumber = true;
		P1_RemainNumber = 100;
		P2_RemainNumber = 100;
	}
	// Update is called once per frame
	void Update()
	{
		anim.SetInteger("State", State);
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

		int P1_Score1 = P1_RemainNumber / 100;  //폰트 적용(100의 자리)
		P1_NumberImg[0].GetComponent<Image>().sprite = Number[P1_Score1];

		int P1_Score2 = P1_RemainNumber % 100; //10의 자리)
		P1_Score2 = P1_Score2 / 10;
		P1_NumberImg[1].GetComponent<Image>().sprite = Number[P1_Score2];

		int P1_Score3 = P1_RemainNumber % 10;
		P1_NumberImg[2].GetComponent<Image>().sprite = Number[P1_Score3];

		int P2_Score1 = P2_RemainNumber / 100;  //폰트 적용(100의 자리)
		P2_NumberImg[0].GetComponent<Image>().sprite = Number[P2_Score1];

		int P2_Score2 = P2_RemainNumber % 100; //10의 자리)
		P2_Score2 = P2_Score2 / 10;
		P2_NumberImg[1].GetComponent<Image>().sprite = Number[P2_Score2];

		int P2_Score3 = P2_RemainNumber % 10;
		P2_NumberImg[2].GetComponent<Image>().sprite = Number[P2_Score3];

	}
	//public void PullButtonClick(bool active)
	//{
	//	NumberCardPopUp.SetActive(active);
	//}

	public void OnClickPull() //팝업창에 숫자뜲
	{
		if (State == 0)
		{
			State = 1;
		}
		else if (State == 1)
		{
			CardNumber = Random.Range(1, 14); // 0~14
			switch (PlayerIndex)
			{
				case 0:
					P1_RemainNumber -= CardNumber;

					PlayerIndex = 1;
					break;

				case 1:
					P2_RemainNumber -= CardNumber;
					PlayerIndex = 0;
					break;
			}
			if (P2_RemainNumber == 22 || P1_RemainNumber < 22)
			{
				P2_WinPopUp.SetActive(true);
				soundPlayer.Play();
				btnPull.enabled = false;
				btnBack.enabled = false;
				EndPopUp.SetActive(true);
			}
			if (P1_RemainNumber == 22 || P2_RemainNumber < 22)
			{
				P1_WinPopUp.SetActive(true);
				soundPlayer.Play();
				btnPull.enabled = false;
				btnBack.enabled = false;
				EndPopUp.SetActive(true);
			}
		}




		IsClear = true;

		ChooseNumber = false;
	}
	public void OnClickExitButton()
	{
		Application.Quit();
	}
	public static void EndAnim()
	{
		Instance.anim.SetBool("IsFirst", false);
	}
	public void ZlroDDi()
	{
		anim.SetBool("Pull ", true);
	}
}

