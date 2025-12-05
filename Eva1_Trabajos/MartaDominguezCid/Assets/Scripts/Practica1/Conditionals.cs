using UnityEngine;

public class Conditionals : MonoBehaviour
{

    //Zona de variables globales

    public int NumberOne;
    public int NumberTwo;
    public char Letter;
    public int DayNumber;
    public char Letra;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsPositive();
        IsOdd();
        IsAsecndingNumber();
        IsVowel();
        IsDayWeek();
        EsVocal();
    }

    private void IsPositive()
    {
        if (NumberOne >= 0)
        {
            Debug.Log(NumberOne + "  es positivo");

        }
        else
        {
            Debug.Log(NumberOne + " es negativo");
        }
    }
    private void IsOdd()
    {
        if(NumberOne % 2 == 0)
        {
            Debug.Log(NumberOne + "  es par");

        }
        else
        {
            Debug.Log(NumberOne + " es impar");
        }
    }

    private void IsAsecndingNumber()
    {
        if(NumberOne < NumberTwo)
        {
            Debug.Log("El orden ascendente de los números es: " + NumberOne + "\t" + NumberTwo);
        }
        else if(NumberOne == NumberTwo)
        {
            Debug.Log("Los dos números son iguales");
        }
        else
        {
            Debug.Log("El orden ascendente de los múmeros es: " + NumberTwo + "\t" + NumberOne);


        }
    }

    private void IsVowel()
    {
        if(Letter == 'a'|| Letter == 'e' || Letter == 'i' || Letter == 'o' || Letter == 'u')
        {

            Debug.Log(Letter + " es una vocal");

        }
        else
        {
            Debug.Log(Letter + " no es una vocal");
        }


        
    }

    private void IsDayWeek()
    {
        switch (DayNumber)
        {
            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miércoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sábado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("El número introducido no se corresponde con ningún día de la semana");
                break;


        }

    }

    private void EsVocal()
    {
        switch (Letra)
        {
            case 'a':
                Debug.Log(Letra + " es una vocal");
                break;
            case 'e':
                Debug.Log(Letra + " es una vocal");
                break;
            case 'i':
                Debug.Log(Letra + " es una vocal");
                break;
            case 'o':
                Debug.Log(Letra + " es una vocal");
                break;
            case 'u':
                Debug.Log(Letra + " es una vocal");
                break;
            default:
                Debug.Log(Letra + " no es una vocal");
                break;
               
        }
            
    }

}
