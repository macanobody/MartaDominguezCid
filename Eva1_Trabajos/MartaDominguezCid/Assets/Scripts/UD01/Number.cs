using NUnit.Framework.Interfaces;
using UnityEngine;

public class Number : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private int _insertNumber;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = GetIncreaseNumber(_insertNumber);
        Debug.Log("El número incrementado es: "+ result);
        

    }
    private int GetIncreaseNumber(int number)
    {
       return number + 1;
    }

    
}
