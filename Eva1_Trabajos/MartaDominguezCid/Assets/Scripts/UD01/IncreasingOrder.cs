using Unity.VisualScripting;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private int _littleNumber,
                _mediumNumber,
                _bigNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsInOrder();
    }
    private void IsInOrder()
    {
        if (_littleNumber < _mediumNumber && _mediumNumber < _bigNumber)
        {
            Debug.Log("Los números están en orden creciente");
        }
        else
        {
            Debug.Log("Inserta los números de forma creciente" );
        }

        
    }
}
