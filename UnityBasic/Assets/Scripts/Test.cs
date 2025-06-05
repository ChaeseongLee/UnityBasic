using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI infoText;

    private int index = 0;

    private string[] lines;

    private string name = "��ä��";
    private int age = 27;
    private float height = 172.6f;
    private string sex = "����";
    private string mbti = "ISTP";
    private float weight = 89.3f;
    private string hobby = "���ϸ��̼� ����";
    private string game1 = "FC�¶���";
    private string game2 = "����ü��";
    private int samdae = 300;


    private void Start()
    {
        lines = new string[]
        {
            "���� �̸��� " + name + "�Դϴ�.\n",
            $"���� ���̴� {age}�� �Դϴ�.\n",
            $"���� {sex}�̰�, Ű�� {height}cm, �����Դ� {weight}kg �Դϴ�.\n",
            "���� mbti�� " + mbti + "�̰�, ��̴� " + hobby + "�Դϴ�.\n",
            $"���� {game1}�� {game2}�� ��� �մϴ�.\n",
            "���� ��ϴ� ���� �����մϴ�. ��� " + samdae + "���� �մϴ�.\n"
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
            infoText.text = "��";
        }
    }
}
