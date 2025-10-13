using System.Runtime.CompilerServices;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Zona de Variables Globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsAscending();
    }

    private void IsAscending()
    {
        if (_numberOne < _numberTwo && _numberTwo < _numberThree)
        {
            Debug.Log("El orden ascendente de los números es: " + _numberOne + _numberTwo + _numberThree);
        }
        else if (_numberTwo < _numberOne && _numberOne < _numberThree)
        {
            Debug.Log("El orden ascendente de los números es: " + _numberTwo + _numberOne + _numberThree);
        }
        else if (_numberTwo < _numberThree && _numberThree < _numberOne)
        {
            Debug.Log("El orden ascendente de los números es: " + _numberTwo + _numberThree + _numberOne);
        }
        else if (_numberOne < _numberThree && _numberThree < _numberTwo)
        {
        Debug.Log("El orden ascendente de los números es: " + _numberOne + _numberThree +  _numberTwo);
        }
        else if (_numberThree < _numberOne && _numberOne < _numberTwo)
        {
        Debug.Log("El orden ascendente de los números es: " + _numberThree + _numberOne + _numberTwo);
        }
        else if (_numberThree < _numberTwo && _numberTwo < _numberOne)
        {
        Debug.Log("El orden ascendente de los números es: " + _numberThree  + _numberTwo +  _numberOne);
        }

        else if (_numberOne == _numberTwo && _numberOne == _numberThree)
        {
            Debug.Log(" Los tres números son iguales ");
        }
        
        else
        {
            Debug.Log("Hay números iguales pero no todos son iguales");
        }
    }
   
}
