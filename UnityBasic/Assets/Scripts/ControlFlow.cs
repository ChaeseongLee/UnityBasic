using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{

    int count = 0;

    private void Awake()
    {
        count = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("�ݺ����� ����ƾ��!");
        }
    }

    // Update is called once per frame
    public void Gacha()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!

        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!

        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        for (int i = 0; i < 10; i++)
        {

            int randomValue = Random.Range(1, 101); // 1�̻� 100 �̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100)

            Debug.Log($"������ ���� {randomValue} �Դϴ�.");
            if (8 <= count)
            {
                count = 0;
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�.!");
            }
            else if (randomValue <= 10) // 10%�� Ȯ�� ; 1 ~ 10 -> 10%
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 20%�� Ȯ�� ; 11 ~ 30 -> 30%
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else if (randomValue <= 50)
            {
                Debug.Log("'����'�� �̾Ҵ�!");
            }
            else if (randomValue <= 70)
            {
                Debug.Log("'��ī��'�� �̾Ҵ�!");
            }
            else // ������ 70%�� Ȯ��
            {
                Debug.Log("'ġġ'�� �̾Ҵ�!");
            }

            count++;
        }
    }

    public void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101); // 1�̻� 100 �̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100)

        switch (randomValue)
        {
            case 1:
                Debug.Log("'��û'�� �̾Ҵ�!");
                break;
            case 2:
                Debug.Log("'��'�� �̾Ҵ�!");
                break;
            default:
                Debug.Log("'ġġ'�� �̾Ҵ�!");
                break;
        }
    }


    public int selectNumbe = 1;
    public void GachaSwitch1()
    {
        int randomValue = Random.Range(1, 101);

        switch (selectNumbe)
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {

                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }

                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {

                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }

                }
                break;
            case 2:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {

                    Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");

                }
                break;
            default:
                Debug.Log("�ƹ��͵� ���� ���ߴ�.");
                break;
        }
    }
}
