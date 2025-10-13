using UnityEngine;

public class Logic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Definir un array de 3 valores lógicos inicializados a falso
        bool[] valores = new bool[3] { false, false, false };

        //Marcar como verdadero la primera posición del array
        valores[0] = true;

        //Imprimir en Consola 
        Debug.Log("primer valor: " + valores[0]);
        Debug.Log("segundo valor: " + valores[1]);
        Debug.Log("tercer valor: " + valores[2]);
    }

    
}
