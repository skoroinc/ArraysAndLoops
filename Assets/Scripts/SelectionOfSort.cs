using TMPro;
using UnityEngine;
public class SelectionOfSort : MonoBehaviour
{
    [SerializeField] TMP_Text _textResult;
    public void OnClickSelectionOfSort()
    {
        int[] arr = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        _textResult.text = "Исходный массив:\n";
        PrintArray(arr);
        SelectionSort(arr);
        _textResult.text += "\nОтсортированный массив:\n";
        PrintArray(arr);
    }
    private void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
    private void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            _textResult.text += num + " ";
        }
        _textResult.text += "\n";
    }
}