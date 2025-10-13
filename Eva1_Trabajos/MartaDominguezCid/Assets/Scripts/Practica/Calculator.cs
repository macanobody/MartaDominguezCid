using NUnit.Framework.Interfaces;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    //Zona de variables globales 
    [SerializeField]
    private float _numberOne;
    [SerializeField]
    private float _numberTwo;
    [SerializeField]
    private bool _isAddition;
    [SerializeField]
    private bool _isSubstraction;
    [SerializeField]
    private bool _isMultiplication;
    [SerializeField]
    private bool _isDivision;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Operations();


    }


    private void Operations()
    {
        if (_isAddition == true)
        {
            GetAddition(_numberOne, _numberTwo);
        }
        if (_isSubstraction == true)
        {
            GetSubstraction(_numberOne, _numberTwo);
        }
        if (_isMultiplication == true)
        {
            GetMultiplication(_numberOne, _numberTwo);
        }
        if (_isDivision == true)
        {
            GetDivision(_numberOne, _numberTwo);
        }
    }

    private void GetAddition(float numberOne, float numberTwo)
    {
        float result = numberOne + numberTwo;
        Debug.Log("La suma del número uno y el número dos es: " + result);

    }

    private void GetSubstraction(float numberOne, float numberTwo)
    {
        float result = numberOne - numberTwo;
        Debug.Log("La resta del numero uno y el numero dos es: " + result);
    }

    private void GetMultiplication(float numberOne, float numberTwo)
    {
        float result = numberOne * numberTwo;
        Debug.Log("La multiplicación de numero uno con numero dos es: " + result);
    }
    private void GetDivision(float numberOne, float numberTwo)
    {
        float result = numberOne / numberTwo;
        Debug.Log("La division de numero uno con numero dos es: " + result);
    }
}
