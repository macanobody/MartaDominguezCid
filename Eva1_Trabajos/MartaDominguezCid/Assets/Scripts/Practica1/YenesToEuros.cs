using UnityEngine;

public class YenesToEuros : MonoBehaviour
{
    //Zona de variables globales
    private float _euro;
    public float Jpy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _euro = 0.0058f;
        Debug.Log(YenToEuro());
    }

    private float YenToEuro()
    {
        //conversion de JPY a Euros
        float conversion = 0.0f;

        //Calcular la conversion

        conversion = Jpy * _euro;

        //Devolver el valor de la conversion

        return conversion;

    }
}
