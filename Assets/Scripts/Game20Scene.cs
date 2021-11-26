using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game20Scene : GameManager
{
    public Button Back_Btn;
    public Button DiceTrun_Btn;
    public Text Player1_Score_Txt, Player2_Score_Txt;
    public Text End_Txt;
    public GameObject End_Pnl;

    int[] Dice = { 0, 0 };
    int[] four1 = new int[4];
    int[] six1 = new int[6];
    int[] twelve1 = new int[12];
    int[] four2 = new int[4];
    int[] six2 = new int[6];
    int[] twelve2 = new int[12];
    int Dice_Choose = 0;
    int Player1_GameTurn = 6, Player2_GameTurn = 6;
    bool firstLan1 = true, firstLan2 = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((player1_hap == 20 || player2_hap == 20) || (player1_fin == true && player2_fin == true)
            || player1_hap + player2_hap == 0)
        {

        }
        else
        {
            End_Pnl.SetActive(true);
        }

        if (DiceTrun_Btn != null)
            DiceTrun_Btn.onClick.AddListener(DiceTurn);
  //      if (Back_Btn != null)
		//{
  //          Back_Btn.onClick.AddListener(Back_Title);
  //          Debug.Log(Back_Btn.onClick);
		//}
    }

    void DiceTurn()
	{
        if (player1_turn == true)
        {
            if (Dice_Choose == 1)
            {
                int[] four1 = { player1_hap * 1, player1_hap * 1, player1_hap + 3, player1_hap - 3 };
                player1_hap = four1[Random.Range(0, 3)];
            }
            else if (Dice_Choose == 2)
            {
                int[] six1 = { player1_hap * 1, player1_hap * 3, 4, -4, player1_hap / 2, player1_hap / 2 };
                player1_hap = four1[Random.Range(0, 5)];
            }
            else if (Dice_Choose == 3)
            {
                int[] twelve2 = { player1_hap * 2, player1_hap * 2, player1_hap * 3, player1_hap * 4,
                    player1_hap + 5, player1_hap + 5, player1_hap + 6, player1_hap + 6, player1_hap - 6, player1_hap - 6,
                    player1_hap / 2, player1_hap / 2, player1_hap / 3, player1_hap / 4 };
                player1_hap = four1[Random.Range(0, 11)];
            }

            

        }
        else if (player2_turn == true)
		{
            if (Dice_Choose == 1)
            {
                int[] four2 = { player2_hap * 1, player2_hap * 1, player2_hap + 3, player2_hap - 3 };
                player2_hap = four1[Random.Range(0, 3)];
            }
            else if (Dice_Choose == 2)
            {
                int[] six2 = { player2_hap * 1, player2_hap * 3, player2_hap + 4, player2_hap - 4, player2_hap / 2, player2_hap / 2 };
                player2_hap = four1[Random.Range(0, 5)];
            }
            else if (Dice_Choose == 3)
            {
                int[] twelve2 = { player2_hap * 2, player2_hap * 2, player2_hap * 3, player2_hap * 4,
                    player2_hap + 5, player2_hap + 5, player2_hap + 6, player2_hap + 6, player2_hap - 6, player2_hap - 6,
                    player2_hap / 2, player2_hap / 2, player2_hap / 3, player2_hap / 4 };
                player2_hap = four1[Random.Range(0, 11)];
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

    private IEnumerator rest()
	{
        yield return null;
	}
    
    public void Back_Title()
	{
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
	}
}
