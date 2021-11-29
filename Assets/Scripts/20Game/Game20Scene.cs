using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Game20Scene : GameManager
{
    #region
    public Button Back_Btn;
    public Button DiceTrun_Btn;
    public Button FourDice_Btn;
    public Button SixDice_Btn;
    public Button TwelveDice_Btn;
    public Button Choose_Yes_Btn;
    public Button Choose_No_Btn;
    public Button Stop_Btn;
    public Text Player1_Score_Txt, Player2_Score_Txt;
    public Text End_Txt;
    public Text Choose_Txt;
    public GameObject End_Pnl;
    public GameObject Choose_Pnl;

    GameManager hap = new GameManager();

    public int Dice_Choose = 0;
    int[] Dice = { 0, 0 };
    int[] four1 = new int[4];
    int[] six1 = new int[6];
    int[] twelve1 = new int[12];
    int[] four2 = new int[4];
    int[] six2 = new int[6];
    int[] twelve2 = new int[12];
    int Player1_GameTurn = 0, Player2_GameTurn = 0;
    bool firstLan1 = true, firstLan2 = true;
    public bool player1_Stop = false, player2_Stop = false;

    public int result01 = 0, result02 = 0;

    public GameObject west_Pnl;
    public GameObject West_Txt;
    public GameObject west_Btn;
    
    public Text Turn_Txt;
    #endregion
    //변수

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1_Stop == true)
            player1_turn = false;
        if (player2_Stop == true)
            player2_turn = false;

        if (firstLan1 == false && firstLan2 == false)
        {
            if (player1_turn == true && player2_turn == false)
                Turn_Txt.text = "Player1의 차례";
            else if (player1_turn == false && player2_turn == true)
                Turn_Txt.text = "Player2의 차례";
        }

        if ((Player1_GameTurn >= 7 && Player2_GameTurn >= 7) || (player1_hap == 20 || player1_hap == 20)
            || (player1_Stop == true && player2_Stop == true))
        {
            End_Pnl.SetActive(true);

            Result();
        }

  //      if (Back_Btn != null)
		//{
  //          Back_Btn.onClick.AddListener(Back_Title);
  //          Debug.Log(Back_Btn.onClick);
		//}
    }

    public void DiceTurn()
	{
        #region
        int Dummy01 = player1_hap * 1;
        int Dummy02 = player1_hap * 3;
        int Dummy03 = player1_hap / 2;
        int Dummy04 = player1_hap * 2;
        int Dummy05 = player1_hap + 5;
        int Dummy06 = player1_hap + 6;
        int Dummy07 = player1_hap - 6;

        int Dummy08 = player2_hap * 1;
        int Dummy09 = player2_hap * 3;
        int Dummy10 = player2_hap / 2;
        int Dummy11 = player2_hap * 2;
        int Dummy12 = player2_hap + 5;
        int Dummy13 = player2_hap + 6;
        int Dummy14 = player2_hap - 6;
        #endregion 
        //더미 변수

        


        if (firstLan1 == true || firstLan2 == true)
        {
            if (Dice_Choose == 0)
            {
                west_Pnl.SetActive(true);
                goto West_On;
            }

            if (player1_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four1 = { Dummy01, Dummy01, player1_hap + 3, player1_hap - 3 };
                    player1_hap = four1[UnityEngine.Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six1 = { Dummy01, Dummy02, player1_hap + 4, player1_hap - 4, Dummy03, Dummy03 };
                    player1_hap = six1[UnityEngine.Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve1 = { Dummy04, Dummy04, Dummy02, player1_hap * 4,
                        Dummy05, Dummy05, Dummy06, Dummy06, Dummy07, Dummy07,
                        Dummy03, Dummy03, player1_hap / 3, player1_hap / 4 };
                    player1_hap = twelve1[UnityEngine.Random.Range(0, 12)];
                }

                NextDice();

            }
            else if (player2_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four2 = { Dummy08, Dummy08, player2_hap + 3, player2_hap - 3 };
                    player2_hap = four1[UnityEngine.Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six2 = { Dummy08, Dummy09, player2_hap + 4, player2_hap - 4, Dummy10, Dummy10};
                    player2_hap = six2[UnityEngine.Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve2 = { Dummy11, Dummy11, Dummy09, player2_hap * 4,
                        Dummy12, Dummy12, Dummy13, Dummy13, Dummy14, Dummy14,
                        Dummy10, Dummy10, player2_hap / 3, player2_hap / 4 };
                    player2_hap = twelve2[UnityEngine.Random.Range(0, 12)];
                }

                NextDice();

            }


        }
        else
		{
            if (player1_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four1 = { Dummy01, Dummy01, player1_hap + 3, player1_hap - 3 };
                    player1_hap = four1[UnityEngine.Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six1 = { Dummy01, Dummy02, player1_hap + 4, player1_hap - 4, Dummy03, Dummy03 };
                    player1_hap = six1[UnityEngine.Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve1 = { Dummy04, Dummy04, Dummy02, player1_hap * 4,
                        Dummy05, Dummy05, Dummy06, Dummy06, Dummy07, Dummy07,
                        Dummy03, Dummy03, player1_hap / 3, player1_hap / 4 };
                    player1_hap = twelve1[UnityEngine.Random.Range(0, 12)];
                }

                Hap();

            }
            else if (player2_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four2 = { Dummy08, Dummy08, player2_hap + 3, player2_hap - 3 };
                    player2_hap = four1[UnityEngine.Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six2 = { Dummy08, Dummy09, player2_hap + 4, player2_hap - 4, Dummy10, Dummy10 };
                    player2_hap = six2[UnityEngine.Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve2 = { Dummy11, Dummy11, Dummy09, player2_hap * 4,
                        Dummy12, Dummy12, Dummy13, Dummy13, Dummy14, Dummy14,
                        Dummy10, Dummy10, player2_hap / 3, player2_hap / 4 };
                    player2_hap = twelve2[UnityEngine.Random.Range(0, 12)];
                }

                Hap();

            }

        }

    West_On:
        Debug.Log("됨");

	}

    void Hap()
	{
        if (player1_turn == true && player2_turn == false)
        {
            player1_turn = false;
            Player1_Score_Txt.text = "Player1_Score : " + player1_hap;
            player2_turn = true;
            Player1_GameTurn++;
        }
        else if (player1_turn == false && player2_turn == true)
        {
            player2_turn = false;
            Player2_Score_Txt.text = "Player2_Score : " + player2_hap;
            player1_turn = true;
            Player2_GameTurn++;
        }

        if (firstLan1 == false && firstLan2 == false)
		{
            if (player1_turn == true && player2_turn == false)
                Turn_Txt.text = "Player1의 차례";
            else if (player1_turn == false && player2_turn == true)
                Turn_Txt.text = "Player2의 차례";
        }
    }

    void NextDice()
	{
        Choose_Pnl.SetActive(true);

        if (firstLan1 == true && firstLan2 == true)
            Choose_Txt.text = "Player1의\n주사위를 더 굴리시겠습니까?";
        else if (firstLan1 == false && firstLan2 == true)
            Choose_Txt.text = "Player2의\n주사위를 더 굴리시겠습니까?";

    }

    void Result()
    {
        

        if (player1_hap < 0)
            result01 = 20 - player1_hap;
        else if (player1_hap > 20)
            result01 = 20 + player1_hap;

        if (player2_hap < 0)
            result02 = 20 - player2_hap;
        else if (player2_hap > 20)
            result02 = 20 + player2_hap;

        if (result01 == result02)
            {
                End_Txt.text = "무승부입니다.";
            }
            else if (result01 < result02)
            {
                End_Txt.text = "player1이 승리하였습니다.\nBack버튼을 클릭하면 \n타이틀로 돌아갑니다.";
            }
            else if (result01 > result02)
            {
                End_Txt.text = "player2이 승리하였습니다.\nBack버튼을 클릭하면 \n타이틀로 돌아갑니다.";
            }
    }

    public void Choose_Yes()
    {
        #region
        int Dummy01 = player1_hap * 1;
        int Dummy02 = player1_hap * 3;
        int Dummy03 = player1_hap / 2;
        int Dummy04 = player1_hap * 2;
        int Dummy05 = player1_hap + 5;
        int Dummy06 = player1_hap + 6;
        int Dummy07 = player1_hap - 6;

        int Dummy08 = player2_hap * 1;
        int Dummy09 = player2_hap * 3;
        int Dummy10 = player2_hap / 2;
        int Dummy11 = player2_hap * 2;
        int Dummy12 = player2_hap + 5;
        int Dummy13 = player2_hap + 6;
        int Dummy14 = player2_hap - 6;
        #endregion
        //더미 변수

        Choose_Pnl.SetActive(false);

        if (player1_turn == true && player2_turn == false)
        {
            if (Dice_Choose == 1)
            {
                int[] four1 = { Dummy01, Dummy01, player1_hap + 3, player1_hap - 3 };
                player1_hap = four1[UnityEngine.Random.Range(0, 4)];
            }
            else if (Dice_Choose == 2)
            {
                int[] six1 = { Dummy01, Dummy02, player1_hap + 4, player1_hap - 4, Dummy03, Dummy03 };
                player1_hap = six1[UnityEngine.Random.Range(0, 6)];
            }
            else if (Dice_Choose == 3)
            {
                int[] twelve1 = { Dummy04, Dummy04, Dummy02, player1_hap * 4,
                        Dummy05, Dummy05, Dummy06, Dummy06, Dummy07, Dummy07,
                        Dummy03, Dummy03, player1_hap / 3, player1_hap / 4 };
                player1_hap = twelve1[UnityEngine.Random.Range(0, 12)];
            }

            firstLan1 = false;
            player1_turn = false;
            player2_turn = true;
            Player1_GameTurn++;
        }
        else if (player1_turn == false && player2_turn == true)
        {
            if (Dice_Choose == 1)
            {
                int[] four2 = { Dummy08, Dummy08, player2_hap + 3, player2_hap - 3 };
                player2_hap = four1[UnityEngine.Random.Range(0, 4)];
            }
            else if (Dice_Choose == 2)
            {
                int[] six2 = { Dummy08, Dummy09, player2_hap + 4, player2_hap - 4, Dummy10, Dummy10 };
                player2_hap = six2[UnityEngine.Random.Range(0, 6)];
            }
            else if (Dice_Choose == 3)
            {
                int[] twelve2 = { Dummy11, Dummy11, Dummy09, player2_hap * 4,
                        Dummy12, Dummy12, Dummy13, Dummy13, Dummy14, Dummy14,
                        Dummy10, Dummy10, player2_hap / 3, player2_hap / 4 };
                player2_hap = twelve2[UnityEngine.Random.Range(0, 12)];
            }

            firstLan2 = false;
            player2_turn = false;
            player1_turn = true;
            Player2_GameTurn++;
        }

        if (firstLan1 == false && firstLan2 == false)
        {
            if (player1_turn == true && player2_turn == false)
                Turn_Txt.text = "Player1의 차례";
            else if (player1_turn == false && player2_turn == true)
                Turn_Txt.text = "Player2의 차례";
        }

    }
    public void Choose_No()
    {
        Choose_Pnl.SetActive(false);
        if (player1_turn == true && player2_turn == false)
        {
            firstLan1 = false;
            player1_turn = false;
            player2_turn = true;
            Player1_GameTurn++;
        }
        else
        {
            firstLan2 = false;
            player2_turn = false;
            player1_turn = true;
            Player2_GameTurn++;
        }

        if (firstLan1 == false && firstLan2 == false)
        {
            if (player1_turn == true && player2_turn == false)
                Turn_Txt.text = "Player1의 차례";
            else if (player1_turn == false && player2_turn == true)
                Turn_Txt.text = "Player2의 차례";
        }

    }
    public void west()
    {
        west_Pnl.SetActive(false);
    }

    public void Stop()
    {
        if (player1_turn == true && player2_turn == false)
        {
            player1_turn = false;
            player2_turn = true;
            player1_Stop = true;
        }
        else if (player1_turn == false && player2_Stop == true)
        {
            player2_turn = false;
            player1_turn = true;
            player2_Stop = true;
        }
    }
    public void FourDice()
	{
        Dice_Choose = 1;
	}
    public void SixDice()
	{
        Dice_Choose = 2;
	}
    public void TwelveDice()
	{
        Dice_Choose = 3;
	}

    private IEnumerator rest()
	{
        yield return null;
	}
    
    public void Back_Title()
	{
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
	}
}
