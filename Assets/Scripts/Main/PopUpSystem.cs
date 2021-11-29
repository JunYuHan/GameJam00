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
	[SerializeField] GameObject HowtoPlayPopUp1;
	[SerializeField] GameObject HowtoPlayPopUp2;
	[SerializeField] GameObject HowtoPlayPopUp3;
	[SerializeField] GameObject HowtoPlayPopUp4;
	[SerializeField] GameObject CreditClose;
 	[SerializeField] GameObject HideImg; //Start 눌렀을 때 다른거 못 건들게
	[SerializeField] GameObject SettingPopUp;
	[SerializeField] GameObject HideImage; //Setting 창 눌렀을 때 다른거 못 건들게

	[SerializeField] Image MusicImage;
	[SerializeField] Sprite MusicSpriteOn;
	[SerializeField] Sprite MusicSpriteOff;

	AudioSource source;
	private void Start()
	{
		HideImage.SetActive(false);
		PopUp.SetActive(false);
		SettingPopUp.SetActive(false);
		anim = GetComponent<Animator>();
		source = Camera.main.GetComponent<AudioSource>();
	}

	void Update()
	{
		//if (Input.GetMouseButtonDown(0))
		//{
		//	OnClickStartButton(true);
		//}
	}

	public void OnClickStartButton(bool active) //플레이 버튼 눌렀을 때
	{
		HideImg.SetActive(active);
		PopUp.SetActive(active);
	}
	public void OnClickSettingButton(bool active)	//Setting Ui눌렀을 때
	{
		SettingPopUp.SetActive(active);
		HideImage.SetActive(active);
	}
	public void OnClickCloseButton(bool active) //세팅 버튼 x 눌렀을 때
    {
		SettingPopUp.SetActive(false);
    }

	public void OnClickOnButton() //사운드 on 눌렀을 때
    {
		source.mute = false;
		MusicImage.sprite = MusicSpriteOn;
	}
	public void OnClickOffButton() //사운드 off눌렀을 때
	{
		source.mute = true;
		MusicImage.sprite = MusicSpriteOff;
	}
	
	public void MoveScene(string sceneName) //씬 이동
	{
		SceneManager.LoadScene(sceneName);
	}
	public void OnClickExitButton()
	{
		Application.Quit();
	}
	public void OnClickHowtoPlay(bool active)
	{
		HowtoPlayPopUp1.SetActive(active);
	}
	public void OnClickXButton()
	{
		HowtoPlayPopUp1.SetActive(false);
		HowtoPlayPopUp2.SetActive(false);
		HowtoPlayPopUp3.SetActive(false);
		HowtoPlayPopUp4.SetActive(false);
	}
	public void OnClickNextButton1()
	{
		HowtoPlayPopUp1.SetActive(false);
		HowtoPlayPopUp2.SetActive(true);
		HowtoPlayPopUp3.SetActive(false);
		HowtoPlayPopUp4.SetActive(false);
	}
	public void OnClickNextButton2()
	{
		HowtoPlayPopUp1.SetActive(false);
		HowtoPlayPopUp2.SetActive(false);
		HowtoPlayPopUp3.SetActive(true);
		HowtoPlayPopUp4.SetActive(false);
	}
	public void OnClickNextButton3()
	{
		HowtoPlayPopUp1.SetActive(false);
		HowtoPlayPopUp2.SetActive(false);
		HowtoPlayPopUp3.SetActive(false);
		HowtoPlayPopUp4.SetActive(true);
	}


}
