using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnChange : MonoBehaviour
{
    public Image P1_Turn;
    float time = 0;
	public float timeSpeed;

	 void Update()
	{
		if(time < timeSpeed)
		{
			P1_Turn.color = new Color(1, 1, 1, time / timeSpeed);
		}
		else
		{
			time = 0;
			//this.gameObject.SetActive(false);
		}
		time += Time.deltaTime;
	}
	
	public void resetAnim()
	{
		P1_Turn.color = new Color(1, 1, 1, 255);
		this.gameObject.SetActive(true);
		time = 0;
	}

}
