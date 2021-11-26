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
    public int[] sum = new int[5];   // 배열은 배열 크기를 정해둬야해서 안좋은게 있지만 효율적임 리스트보다 주소 할당을 적게 받아서 메모리가 덜 먹음
    //public List<int> sum = new List<int>();   // List 리스트는 배열 크기 안정해두고 List.Add로 계속 추가 가능, *(List.Remove, List.RemoveAt, List.RemoveAtAll로 삭제도 가능)
    public int Now_Sum_Number;
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

    public void OnClickPull() //팝업창에 숫자뜲
    {
        CardNumber = Random.Range(0, 14);
        sum[Now_Sum_Number] += CardNumber;
        NumberText.text = string.Format("{0}", CardNumber.ToString());
        ChooseNumber = false;
    }

}
