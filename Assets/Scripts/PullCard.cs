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
    public int[] sum = new int[5];   // �迭�� �迭 ũ�⸦ ���ص־��ؼ� �������� ������ ȿ������ ����Ʈ���� �ּ� �Ҵ��� ���� �޾Ƽ� �޸𸮰� �� ����
    //public List<int> sum = new List<int>();   // List ����Ʈ�� �迭 ũ�� �����صΰ� List.Add�� ��� �߰� ����, *(List.Remove, List.RemoveAt, List.RemoveAtAll�� ������ ����)
    public int Now_Sum_Number;
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

    public void OnClickPull() //�˾�â�� ���ڍ�
    {
        CardNumber = Random.Range(0, 14);
        sum[Now_Sum_Number] += CardNumber;
        NumberText.text = string.Format("{0}", CardNumber.ToString());
        ChooseNumber = false;
    }

}
