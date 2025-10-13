using System.Runtime.CompilerServices;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetPositiveNumbers();
        GetNegativeNumbers();
    }

    private void GetPositiveNumbers()
    {
        int[] numbersArray = new int[10] { 1, 2, 3, -5, -8, -9, 0, 23, -23, 8 };
        //int[] numbersArray = {1, 2, 3, -5, -8, -9, 0, 23, -23, 8};
        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] >= 0)
            {
                Debug.Log("Positivo: " + numbersArray[i]);
            }

        }

    }
    private void GetNegativeNumbers()
    {
        int[] numbersArray = { 1, 2, 3, -5, -8, -9, 0, 23, -23, 8 };
        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] < 0)
            {
                Debug.Log("Negativo: " + numbersArray[i]);
            }
        }
    }
   
}
