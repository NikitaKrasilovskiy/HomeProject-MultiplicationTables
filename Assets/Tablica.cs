using UnityEngine;
using TMPro;
using System;

public class Tablica : MonoBehaviour
{
    public TMP_InputField inputFieldChetnie;
    public TextMeshProUGUI otvet;
    public void Chetnie()
    {
        int a = Convert.ToInt32(inputFieldChetnie.text);

        for (int i = 2; i < a; i++)
        {
            if (i % 2 == 0)
            { otvet.text += $"{i}\n"; }
        }
    }
    public void OchischenieChetnie()
    {
        otvet.text = " ";
    }

    public TextMeshProUGUI umnojenie;
    public void Umnojenie()
    {
        string[] str = new string[10];

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                str[i] = ($"{i}*{j}={i*j}\n");

                umnojenie.text += $"{str[i]}";
            }
        }
    }

    public TMP_InputField inputFieldFactorial;
    public TextMeshProUGUI factorial;
    public void Factorial()
    {
        int g = Convert.ToInt32(inputFieldFactorial.text);

        int f = 1;

        for (int r = 2; r <= g; r++)
        { f = f * r; }

        factorial.text += $"{f}";
    }

    public void OchischenieFactorial()
    {
        factorial.text = " ";
    }
}