using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star = "��"; // ��
    string empty = "��"; // ��ĭ
    string enter = "\n"; // �ٹٲ�
    string stack = "";

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        Debug.Log(enter);

        for (int i = 0; i < 5; i++)
        {
            stack += star + enter;
            star += "��";
        }

        Debug.Log(stack);

    }

    public void Phase2()
    {
        stack = "";
        star = "��";

        // ������ 2
        for (int i = 0; i < 5; i++)
        {
            for(int j = 3; j >= i; j--)
            {
                star += "��";
            }

            stack += empty + star + enter;
            empty += "��";
            star = "��";

        }

        Debug.Log(stack);
    }

    public void Phase3()
    {
        stack = "";
        star = "��";
        empty = "��";

        for (int i = 0; i < 5; i++)
        {
            stack += star + enter;
            star += "��";
            
        }

        star = "��";

        for (int i = 0; i < 4; i++)
        {
            for (int j = 2; j >= i; j--)
            {
                star += "��";
            }

            stack += star + enter;
            star = "��";

        }

        Debug.Log(stack);

    }

    public void Phase4()
    {
        stack = "";
        star = "��";
        empty = "��";
        for(int k = 0; k < 4; k++)
        {
            for(int l = 3; l >= k; l--)
            {
                empty += "��";
            }
            stack += empty + star + enter;
            empty = "��";
            star += "��";
        }

        star = "��";
        // ������ 2
        for (int i = 0; i < 5; i++)
        {
            for (int j = 3; j >= i; j--)
            {
                star += "��";
            }

            stack += empty + star + enter;
            empty += "��";
            star = "��";

        }

        Debug.Log(stack);
    }

    public void Phase5()
    {
        stack = "";
        string star1 = "��";
        string star2 = "";
        empty = "��";

        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j >= i; j--)
            {
                empty += "��";

            }
            stack += empty + star1 + star2 + enter;
            star1 += "��";
            star2 += "��";

            empty = "��";

        }

        star1 = "";
        star2 = "��";

        for (int i = 0; i < 4; i++)
        {
            for (int j = 2; j >= i; j--)
            {
                star1 += "��";
                star2 += "��";


            }
            empty += "��";
            stack += empty + "��" + star1 + star2 + enter;
            star1 = "";
            star2 = "��";



        }


        Debug.Log(stack);
    }
}
