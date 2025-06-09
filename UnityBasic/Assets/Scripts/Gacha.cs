using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gacha : MonoBehaviour
{
    public Button buttonOne;
    public Button buttonTwo;

    public List<Image> resultImage = new List<Image>(); // ��� �̹��� ����Ʈ
    public List<Sprite> characterList = new List<Sprite>(); // ĳ���� ��������Ʈ ����Ʈ
    public List<TextMeshProUGUI> Txt_Name = new List<TextMeshProUGUI>(); // ĳ���� �̸� �ؽ�Ʈ ����Ʈ

    void Start()
    {
        buttonOne.onClick.AddListener(() => OnButtonClick(1));
        buttonTwo.onClick.AddListener(() => OnButtonClick(2));
    }

    void OnButtonClick(int buttonIndex)
    {
        int randomValue;

        if (buttonIndex == 1)
        {
            Debug.Log("1ȸ �̱� ��ư Ŭ����");
            randomValue = Random.Range(1, 105);
            SetGachaResult(randomValue, 0);
        }
        else if (buttonIndex == 2)
        {
            Debug.Log("10ȸ �̱� ��ư Ŭ����");
            for (int i = 0; i < 10; i++)
            {
                randomValue = Random.Range(1, 150);
                SetGachaResult(randomValue, i);
            }
        }
    }

    void SetGachaResult(int value, int index)
    {
        string characterName = "��";
        Sprite characterSprite = null;

        if (value <= 5)
        {
            characterName = "Eren Yeager";
            characterSprite = characterList[0];
        }
        else if (value <= 10)
        {
            characterName = "Mikasa Ackerman";
            characterSprite = characterList[1];
        }
        else if (value <= 35)
        {
            characterName = "Armin Arlert";
            characterSprite = characterList[2];
        }
        else if (value <= 65)
        {
            characterName = "Jean Kirstein";
            characterSprite = characterList[3];
        }
        else
        {
            characterName = "Sasha Blouse";
            characterSprite = characterList[4];
        }

        // �̹��� ǥ��
        if (index < resultImage.Count)
        {
            resultImage[index].sprite = characterSprite;
            resultImage[index].gameObject.SetActive(true);
        }

        // �ؽ�Ʈ ǥ��
        if (index < Txt_Name.Count)
        {
            Txt_Name[index].text = characterName;

            Txt_Name[index].gameObject.SetActive(true);
        }
    }
}
