using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PopUpSystem : MonoBehaviour
{
	Animator anim;
	[SerializeField] GameObject PopUp;
	[SerializeField] GameObject start;
	[SerializeField] GameObject Credit;
	[SerializeField] GameObject HideImg;
	[SerializeField] GameObject SettingPopUp;

	private void Start()
	{
		PopUp.SetActive(false);
		SettingPopUp.SetActive(false);
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		//if (Input.GetMouseButtonDown(0))
		//{
		//	OnClickStartButton(true);
		//}

	}

	public void OnClickStartButton(bool active)
	{
		HideImg.SetActive(active);
		PopUp.SetActive(active);
	}
	public void OnClickSettingButton(bool active)
	{
		SettingPopUp.SetActive(active);
	}
	public void OnClickCloseButton(bool active)
    {
		SettingPopUp.SetActive(false);
    }

	public void MoveScene(string sceneName) //æ¿ ¿Ãµø
	{
		SceneManager.LoadScene(sceneName);
	}

}
