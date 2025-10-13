using UnityEngine;

public class Week : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private int _dayNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsDayWeek();
    }
    private void IsDayWeek()
    {
        switch (_dayNumber)
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
                Debug.Log("No corresponde a ningún día de la semana");
                break;

           
        }
    }

   
}
