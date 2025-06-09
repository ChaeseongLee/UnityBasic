using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gacha : MonoBehaviour
{
    public Button buttonOne;
    public Button buttonTwo;

    public List<Image> resultImage = new List<Image>(); // 결과 이미지 리스트
    public List<Sprite> characterList = new List<Sprite>(); // 캐릭터 스프라이트 리스트
    public List<TextMeshProUGUI> Txt_Name = new List<TextMeshProUGUI>(); // 캐릭터 이름 텍스트 리스트

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
            Debug.Log("1회 뽑기 버튼 클릭됨");
            randomValue = Random.Range(1, 105);
            SetGachaResult(randomValue, 0);
        }
        else if (buttonIndex == 2)
        {
            Debug.Log("10회 뽑기 버튼 클릭됨");
            for (int i = 0; i < 10; i++)
            {
                randomValue = Random.Range(1, 150);
                SetGachaResult(randomValue, i);
            }
        }
    }

    void SetGachaResult(int value, int index)
    {
        string characterName = "꽝";
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

        // 이미지 표시
        if (index < resultImage.Count)
        {
            resultImage[index].sprite = characterSprite;
            resultImage[index].gameObject.SetActive(true);
        }

        // 텍스트 표시
        if (index < Txt_Name.Count)
        {
            Txt_Name[index].text = characterName;

            Txt_Name[index].gameObject.SetActive(true);
        }
    }
}
