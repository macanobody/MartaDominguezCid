using UnityEngine;

public class Change : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Definir el array de 5 valores
        int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
        //Imprimir por consola el array.
        Debug.Log(" Los numeros del array son: " + numeros.Length);
        //Cambiar la primera y última posición
        numeros[0] = 42;
        numeros[4] = 42;
        //Imprimir el valor de cada posición
        Debug.Log("Valor de la posición uno: " + numeros[0]);
        Debug.Log("Valor de la posición dos: " + numeros[1]);
        Debug.Log("Valor de la posición tres: " + numeros[2]);
        Debug.Log("Valor de la posición cuatro: " + numeros[3]);
        Debug.Log("Valor de la posición cinco: " + numeros[4]);
        
    }

    
}
