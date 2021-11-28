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
	public GameObject Image; //�޴�ȭ������ ���ư��� �ٸ��� �� �������ϱ� ���ؼ�
	private bool IsClear;
	private int PlayerIndex; //0,1(0�̸� P1/1�̸� P2)

	private int CardNumber; //���� ��
	private int P1_RemainNumber; // 100���� CardNumber �� ��
	private int P2_RemainNumber; // 100���� CardNumber �� ��
	public int[] sum = new int[5];   // �迭�� �迭 ũ�⸦ ���ص־��ؼ� �������� ������ ȿ������ ����Ʈ���� �ּ� �Ҵ��� ���� �޾Ƽ� �޸𸮰� �� ����
									 //public List<int> sum = new List<int>();   // List ����Ʈ�� �迭 ũ�� �����صΰ� List.Add�� ��� �߰� ����, *(List.Remove, List.RemoveAt, List.RemoveAtAll�� ������ ����)
	bool ChooseNumber; //PULL�� �������� ���ڰ� �Ѱ��� ������ �Ϸ��� ����
	void Start()
	{
		IsClear = false;
		ChooseNumber = true;
		P1_RemainNumber = 100;
		P2_RemainNumber = 100;
		NumberText1.text = P1_RemainNumber.ToString(); // P1�� ���ڰ� �ؽ�Ʈ�� �����߱� ���� 
		NumberText2.text = P2_RemainNumber.ToString(); // P2�� ���ڰ� �ؽ�Ʈ�� �����߱� ���� 
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

	public void OnClickPull() //�˾�â�� ���ڍ�
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
