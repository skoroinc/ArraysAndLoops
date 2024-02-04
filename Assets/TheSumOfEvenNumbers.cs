using TMPro;
using UnityEngine;
public class TheSumOfEvenNumbers : MonoBehaviour
{
    [SerializeField] TMP_Text _textResult;
    private int min = 7;
    private int max = 21;
    void Start()
    {
        _textResult.text = "";
    }
    public void OnClickTheSumOfEvenNumbers()
    {
        int result = SumEvenNumbers(min, max);
        _textResult.text = $"����� ������ ����� � �������� ���������, �� 7 �� 21, ����� {result}";
    }
    private int SumEvenNumbers(int min, int max)
    {
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}