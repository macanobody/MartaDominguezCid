using UnityEngine;

public class DollarsToEuros : MonoBehaviour
{
    //variables globales
    private float _euro;
    public float Dollar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _euro = 0.90f;
        Debug.Log(DollarToEuro());

    }

   private float DollarToEuro()
    {

        //variables locales

        float conversion = 0.0f;

        //Calcular la conversión de dolares a euros

        conversion = Dollar * _euro;

        //Devolver el valor de tipo float

        return conversion;

    }
}
