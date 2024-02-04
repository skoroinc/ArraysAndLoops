using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheSumOfEvenNumbers : MonoBehaviour
{
    [SerializeField] TMP_Text _textResult;
    private int min = 7;
    private int max = 21;
    private int sum = 0;

    void Start()
    {
        _textResult.text = "";
    }

    public void OnClickTheSumOfEvenNumbers()
    {
        SumEvenNumbers(min, max);
    }
    private int SumEvenNumbers(int min, int max)
    {

        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        _textResult.text = $"����� ������ ����� � �������� ���������, �� 7 �� 21, ����� {sum}";
        return sum;
    }


}

