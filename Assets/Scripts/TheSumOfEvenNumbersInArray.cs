using TMPro;
using UnityEngine;
public class TheSumOfEvenNumbersInArray : MonoBehaviour
{
    [SerializeField] TMP_Text _textResult;
    private int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
    private void Start()
    {
        _textResult.text = "";
    }
    public void OnClickTheSumOfEvenNumbersInArray()
    {
        int sum;
        SumEvenNumbersArray(out sum);
        _textResult.text = $"Сумма четных чисел в заданном массиве, равна {sum}";
    }
    private void SumEvenNumbersArray(out int sum)
    {
        sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
    }
}