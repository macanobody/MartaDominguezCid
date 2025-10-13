using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Crear array de cinco cadenas de predicciones
        string[] predicciones = new string[5]
        {
            "Vas a lograr algo que pensabas imposible.",
            "Conocerás a alguien que cambiará tu vida.",
            "Tendrás una idea brillante muy pronto.",
            "Vas a aprobar todas las asignaturas",
            "Te va a tocar la loteria."
        };

        //Crear un número aleatorio

        int random = Random.Range(0, 5);

        //Imprimir la predicción segun el número aleatorio
        
        Debug.Log("predicción aleatoria: " + predicciones[random]);
        
    }

    
}
