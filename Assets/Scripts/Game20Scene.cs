using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game20Scene : GameManager
{
    float[] Dice = { 0, 0 };
    bool firstLan1 = true, firstLan2 = true;

    public Button Dice_btn;
    public Text Dice_Txt;

    // Start is called before the first frame update
    void Start()
    {
        if (firstLan1 == true && firstLan2 == true)
		{

		}
		else
		{

		}
    }

    // Update is called once per frame
    void Update()
    {
        if (Dice_btn != null)
            Dice_btn.onClick.AddListener(Dice_reroll);
    }

    void Dice_reroll()
	{
        
	}

}
