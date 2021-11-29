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
	[SerializeField] GameObject CreditClose;
 	[SerializeField] GameObject HideImg; //Start ������ �� �ٸ��� �� �ǵ��
	[SerializeField] GameObject SettingPopUp;
	[SerializeField] GameObject HideImage; //Setting â ������ �� �ٸ��� �� �ǵ��

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

	public void OnClickStartButton(bool active) //�÷��� ��ư ������ ��
	{
		HideImg.SetActive(active);
		PopUp.SetActive(active);
	}
	public void OnClickSettingButton(bool active)	//Setting Ui������ ��
	{
		SettingPopUp.SetActive(active);
		HideImage.SetActive(active);
	}
	public void OnClickCloseButton(bool active) //���� ��ư x ������ ��
    {
		SettingPopUp.SetActive(false);
    }

	public void OnClickOnButton() //���� on ������ ��
    {
		source.mute = false;
		MusicImage.sprite = MusicSpriteOn;
	}
	public void OnClickOffButton() //���� off������ ��
	{
		source.mute = true;
		MusicImage.sprite = MusicSpriteOff;
	}
	public void OnClickCreditOnButton()
    {
		Credit.SetActive(true);
    }
	public void OnClickCreditOffButton()
    {
		Credit.SetActive(false);
    }
	public void MoveScene(string sceneName) //�� �̵�
	{
		SceneManager.LoadScene(sceneName);
	}
	public void OnClickExitButton()
	{
		Application.Quit();
	}
}
