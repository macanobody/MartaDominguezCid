using NUnit.Framework.Interfaces;
using UnityEngine;

public class Substraction : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private int _number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetSubstraction();
    }
    private void GetSubstraction()
    {
        for (int i = 1; i <= _number; i++)
        {
            int result = _number - i;
            Debug.Log(_number + " - " + i + " = " + result);
        }
    }
    
}
