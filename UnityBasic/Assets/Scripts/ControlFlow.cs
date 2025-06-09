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
            Debug.Log("반복문이 실행됐어요!");
        }
    }

    // Update is called once per frame
    public void Gacha()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!

        // 확률이 20%면 로그에 '모나'를 뽑았다!

        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        for (int i = 0; i < 10; i++)
        {

            int randomValue = Random.Range(1, 101); // 1이상 100 미만의 랜덤한 값을 받아 오겠다. (1 ~ 100)

            Debug.Log($"랜덤한 값은 {randomValue} 입니다.");
            if (8 <= count)
            {
                count = 0;
                Debug.Log("확정으로 '각청'을 뽑았다.!");
            }
            else if (randomValue <= 10) // 10%의 확률 ; 1 ~ 10 -> 10%
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30) // 20%의 확률 ; 11 ~ 30 -> 30%
            {
                Debug.Log("'모나'를 뽑았다!");
            }
            else if (randomValue <= 50)
            {
                Debug.Log("'에렌'를 뽑았다!");
            }
            else if (randomValue <= 70)
            {
                Debug.Log("'미카사'를 뽑았다!");
            }
            else // 나머지 70%의 확률
            {
                Debug.Log("'치치'를 뽑았다!");
            }

            count++;
        }
    }

    public void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101); // 1이상 100 미만의 랜덤한 값을 받아 오겠다. (1 ~ 100)

        switch (randomValue)
        {
            case 1:
                Debug.Log("'각청'을 뽑았다!");
                break;
            case 2:
                Debug.Log("'모나'을 뽑았다!");
                break;
            default:
                Debug.Log("'치치'을 뽑았다!");
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
                // 은색 머리 캐릭터가 나온다
                {

                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }

                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {

                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }

                }
                break;
            case 2:
                // 파란 머리 캐릭터가 나온다
                {

                    Debug.Log("'분홍 머리'을 뽑았다!");

                }
                break;
            default:
                Debug.Log("아무것도 뽑지 못했다.");
                break;
        }
    }
}
