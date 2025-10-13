using UnityEngine;

public class PesetasToEuros : MonoBehaviour
{
    //Zona de variables globales
    private float _euro;
    public float Peseta;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _euro = 0.000080f;

        Debug.Log(PesetasToEuro());

    }

    private float PesetasToEuro()
    {
        // variables locales

        float conversion = 0.0f;

        //Calcular la conversion

        conversion = Peseta * _euro;
        
        // Devolver el valor tipo conversion

        return conversion;
    }
    
      
            
    
}
