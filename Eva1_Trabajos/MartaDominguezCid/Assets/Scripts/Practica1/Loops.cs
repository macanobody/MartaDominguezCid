using UnityEngine;

public class Loops : MonoBehaviour
{
    //Zona de variables globales

    public int Number;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetNumber0To100While();
        GetNumber100To0While();
        GetNumber0To100For();
        GetNumber100To0For();
        GetNumbers1toNumberWhile();
        GetNumbers1toNumberFor();
    }
    private void GetNumber0To100While()
    {
        //crear e inicializar la variable de incremento.

        int i = 0;

        //crear el "while"
        while(i < 101)
        {
            Debug.Log(i);
            i++; // i + 1 -> incremento
        }

    }
    private void GetNumber0To100For()
    {
        for(int i = 0; i< 101; i++)
        {
            Debug.Log(i);
        }
        

    }

    private void GetNumber100To0While()
    {
        //Crear e inicializar el incremento
        int i = 100;
        //crear el while
        while(i > -1)
        {
            Debug.Log(i);
            i--;
        }
    }
    private void GetNumber100To0For()
    {
        for(int i = 100; i > -1; i--)
        {
            Debug.Log(i);
        }
    }
    private void GetNumbers1toNumberWhile()
    {
        //crear incremento
        int i = 1;
        //crear el while
        while (i <= Number)
        {
            Debug.Log(i);
            i++;
        }
       
    }
    
    private void GetNumbers1toNumberFor()
    {
        for (int i = 1; i <= Number; i++)
        {
            Debug.Log(i);
        }
    }
    
        


}
