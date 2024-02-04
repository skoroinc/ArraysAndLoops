using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheSumOfEvenNumbersInArray : MonoBehaviour
{

    [SerializeField] TMP_Text _textResult;
    private int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
    private int sum = 0;


    private void Start()
    {
        _textResult.text = "";
    }

    public void OnClickTheSumOfEvenNumbersInArray()
    {
        SumEvenNumbersArray();
    }


    private int SumEvenNumbersArray()
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        _textResult.text = $"Сумма четных чисел в заданном массиве, равна {sum}";
        return sum;
    }
}
