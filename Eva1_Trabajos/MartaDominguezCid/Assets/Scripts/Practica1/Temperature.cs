using UnityEngine;

public class Temperature : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private float _celsius,
                _fahrenheit;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        GetCelsiusToFahrenheit();
        GetFahrenheitToCelsius();

    }
    private void GetCelsiusToFahrenheit()
    {

        //calcular los grados
        float _fahrenheit = (1.8f) * _celsius + 32.0f;
       

        //Mostrar por consola

        Debug.Log(_celsius + "°C son " + _fahrenheit + "°F");

    }
    private void GetFahrenheitToCelsius()
    {
    

        //calcular temperatura
        
        float _celsius = (_fahrenheit - 32.0f) / 1.8f;

        //Mostrar por consola
        Debug.Log(_fahrenheit + "°F son " + _celsius + "°C");
    }
}
