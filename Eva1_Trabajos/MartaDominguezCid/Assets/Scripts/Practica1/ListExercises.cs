using UnityEngine;
using System.Collections.Generic;

public class ListExercises : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetPositiveNumbers();
        GetNegativeNumbers();
    }

    private void GetPositiveNumbers()
    {
        List<int> numbersList = new List<int>() { -3, 8, 23, -19, 1, -2, 4, 6, -23, -32 };
        foreach (int item in numbersList)
        {
            if (item >= 0)
            {
                Debug.Log(item);
            }
        }


    }
    private void GetNegativeNumbers()
    {
        List<int> numbersList = new List<int>() { -3, 8, 23, -19, 1, -2, 4, 6, -23, -32 };
        //si quiero añadir un numero añadimos Add(x);
        numbersList.Add(-69);
        foreach (int item in numbersList)
        {
            if (item < 0)
            {
                Debug.Log("número negativo: " + item);
            }
        }
    }
}
