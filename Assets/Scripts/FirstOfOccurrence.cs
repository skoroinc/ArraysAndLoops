using TMPro;
using UnityEngine;
public class FirstOfOccurrence : MonoBehaviour
{
    [SerializeField] TMP_Text _textResult;
    public void OnClickFirstOfOccurrebce()
    {
        _textResult.text = "��������� ������� � �������";
        int[] arr1 = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int target1 = 34;
        int result1 = FindFirstOccurrence(arr1, target1);
        Debug.Log($"������ ������� ��������� ����� {target1} � ������: {result1}");

        int[] arr2 = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int target2 = 55;
        int result2 = FindFirstOccurrence(arr2, target2);
        Debug.Log($"������ ������� ��������� ����� {target2} � ������: {result2}"); 
    }
    private int FindFirstOccurrence(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
