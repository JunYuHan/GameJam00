using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game20Scene : GameManager
{
    public Button Back_Btn;
    public Button DiceTrun_Btn;
    public Button FourDice_Btn;
    public Button SixDice_Btn;
    public Button TwelveDice_Btn;
    public Text Player1_Score_Txt, Player2_Score_Txt;
    public Text End_Txt;
    public Text Choose_Txt;
    public GameObject End_Pnl;
    public GameObject Choose_Pnl;

    public int Dice_Choose = 0;
    int[] Dice = { 0, 0 };
    int[] four1 = new int[4];
    int[] six1 = new int[6];
    int[] twelve1 = new int[12];
    int[] four2 = new int[4];
    int[] six2 = new int[6];
    int[] twelve2 = new int[12];
    int Player1_GameTurn = 6, Player2_GameTurn = 6;
    bool firstLan1 = true, firstLan2 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if ((player1_hap == 20 || player2_hap == 20) || (player1_fin == true && player2_fin == true)
        //    || player1_hap + player2_hap == 0)
        //{

        //}
        //else
        //{
        //    End_Pnl.SetActive(true);
        //}

  //      if (Back_Btn != null)
		//{
  //          Back_Btn.onClick.AddListener(Back_Title);
  //          Debug.Log(Back_Btn.onClick);
		//}
    }

    public void DiceTurn()
	{
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

        if (firstLan1 == true || firstLan2 == true)
        {
            if (player1_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four1 = { Dummy01, Dummy01, player1_hap + 3, player1_hap - 3 };
                    player1_hap = four1[Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six1 = { Dummy01, Dummy02, player1_hap + 4, player1_hap - 4, Dummy03, Dummy03 };
                    player1_hap = six1[Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve1 = { Dummy04, Dummy04, Dummy02, player1_hap * 4,
                        Dummy05, Dummy05, Dummy06, Dummy06, Dummy07, Dummy07,
                        Dummy03, Dummy03, player1_hap / 3, player1_hap / 4 };
                    player1_hap = twelve1[Random.Range(0, 12)];
                }

                NextDice();

            }
            else if (player2_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four2 = { Dummy08, Dummy08, player2_hap + 3, player2_hap - 3 };
                    player2_hap = four1[Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six2 = { Dummy08, Dummy09, player2_hap + 4, player2_hap - 4, Dummy10, Dummy10};
                    player2_hap = six2[Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve2 = { Dummy11, Dummy11, Dummy09, player2_hap * 4,
                        Dummy12, Dummy12, Dummy13, Dummy13, Dummy14, Dummy14,
                        Dummy10, Dummy10, player2_hap / 3, player2_hap / 4 };
                    player2_hap = twelve2[Random.Range(0, 12)];
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
                    player1_hap = four1[Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six1 = { Dummy01, Dummy02, player1_hap + 4, player1_hap - 4, Dummy03, Dummy03 };
                    player1_hap = six1[Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve1 = { Dummy04, Dummy04, Dummy02, player1_hap * 4,
                        Dummy05, Dummy05, Dummy06, Dummy06, Dummy07, Dummy07,
                        Dummy03, Dummy03, player1_hap / 3, player1_hap / 4 };
                    player1_hap = twelve1[Random.Range(0, 12)];
                }



            }
            else if (player2_turn == true)
            {
                if (Dice_Choose == 1)
                {
                    int[] four2 = { Dummy08, Dummy08, player2_hap + 3, player2_hap - 3 };
                    player2_hap = four1[Random.Range(0, 4)];
                }
                else if (Dice_Choose == 2)
                {
                    int[] six2 = { Dummy08, Dummy09, player2_hap + 4, player2_hap - 4, Dummy10, Dummy10 };
                    player2_hap = six2[Random.Range(0, 6)];
                }
                else if (Dice_Choose == 3)
                {
                    int[] twelve2 = { Dummy11, Dummy11, Dummy09, player2_hap * 4,
                        Dummy12, Dummy12, Dummy13, Dummy13, Dummy14, Dummy14,
                        Dummy10, Dummy10, player2_hap / 3, player2_hap / 4 };
                    player2_hap = twelve2[Random.Range(0, 12)];
                }

                

            }
        }

	}

    void Hap()
	{
        if (firstLan1 == true || firstLan2 == true)
        {
            if (player1_turn == true && player2_turn == false)
			{
                player1_hap += (Dice[0] + Dice[1]);
                player1_turn = false;
                firstLan1 = false;
                Player1_GameTurn--;
                player2_turn = true;

			}
            else
			{
                player2_hap += (Dice[0] + Dice[1]);
                player2_turn = false;
                firstLan2 = false;
                Player2_GameTurn--;
                player1_turn = true;
			}

        }
        else
        {
            if (player1_turn == true && player2_turn == false)
			{
                player1_hap += Dice[0];
                player1_turn = false;
                Player1_GameTurn--;
                player2_turn = true;
			}
			else
			{
                player2_hap += Dice[0];
                player2_turn = false;
                Player2_GameTurn--;
                player1_turn = true;
			}

        }

    }

    void NextDice()
	{
        
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
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
	}
}
