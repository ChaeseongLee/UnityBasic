using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI infoText;

    private int index = 0;

    private string[] lines;

    private string name = "이채성";
    private int age = 27;
    private float height = 172.6f;
    private string sex = "남자";
    private string mbti = "ISTP";
    private float weight = 89.3f;
    private string hobby = "에니메이션 보기";
    private string game1 = "FC온라인";
    private string game2 = "롤토체스";
    private int samdae = 300;


    private void Start()
    {
        lines = new string[]
        {
            "저의 이름은 " + name + "입니다.\n",
            $"저의 나이는 {age}세 입니다.\n",
            $"저는 {sex}이고, 키는 {height}cm, 몸무게는 {weight}kg 입니다.\n",
            "저의 mbti는 " + mbti + "이고, 취미는 " + hobby + "입니다.\n",
            $"저는 {game1}과 {game2}를 즐겨 합니다.\n",
            "저는 운동하는 것을 좋아합니다. 삼대 " + samdae + "정도 합니다.\n"
        };
    }
    public void OnButtonClick()
    {
        if(index < lines.Length)
        {
            
            infoText.text = lines[index++];
        }
        else
        {
            infoText.text = "끝";
        }
    }
}
