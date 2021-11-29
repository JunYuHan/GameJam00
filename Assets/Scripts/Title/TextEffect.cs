using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    public Text txtTemp;

    private void Start()
    {
        //StartCoroutine(EFadeLoop(txtTemp, new Color[2] { Color.black, Color.clear }, 5));
    }

    float sin_value = 0;
    private void Update()
    {
        sin_value += 200 * Time.deltaTime;
        txtTemp.color = new Color(txtTemp.color.r, txtTemp.color.g, txtTemp.color.b, Mathf.Sin(sin_value * Mathf.Deg2Rad) / 2 + 0.5f);
    }

    /// <summary>
    /// �ؽ�Ʈ(Text)�� Ÿ���� ȿ�� �ִ� �Լ�
    /// </summary>
    /// <param name="text">ȿ���� ���� Text Component</param>
    /// <param name="changeStr">Ÿ������ �� ���ڿ�</param>
    /// <param name="oneLatterDelay">�ϳ� Ÿ���εǴ� ������</param>
    public void TypingText(Text text, string changeStr, float oneLatterDelay)
    {
        StartCoroutine(ETypingText(text, changeStr, oneLatterDelay));
    }

    IEnumerator ETypingText(Text text, string changeStr, float oneLatterDelay)
    {
        var wait = new WaitForSeconds(oneLatterDelay);
        for (int i = 0; i <= changeStr.Length; i++)
        {
            text.text = changeStr.Substring(0, i);
            yield return wait;
        }
        yield return null;
    }

    IEnumerator EColoringUI(Graphic ui, Color change_color, float change_speed)
    {
        var wait = new WaitForSeconds(0.0001f);

        while (Mathf.Abs(ui.color.r - change_color.r) +
            Mathf.Abs(ui.color.g - change_color.g) +
            Mathf.Abs(ui.color.b - change_color.b) +
            Mathf.Abs(ui.color.a - change_color.a) > 0.005f)
        {
            ui.color = Color.Lerp(ui.color, change_color, Time.deltaTime * change_speed);
            yield return wait;
        }
        ui.color = change_color;

        yield return null;
    }

    IEnumerator EFadeLoop(Graphic ui, Color[] colors, float change_speed)
    {
        while (true)
        {
            yield return StartCoroutine(EColoringUI(ui, colors[0], change_speed));
            yield return StartCoroutine(EColoringUI(ui, colors[1], change_speed));
        }
    }
}
