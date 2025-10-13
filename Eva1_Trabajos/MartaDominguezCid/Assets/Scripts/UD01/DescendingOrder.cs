using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    [SerializeField]
    private int _bigNumber,
            _mediumNumber,
            _littleNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsInDescendingOrder();
    }
    private void IsInDescendingOrder()
    {
        
        if (_bigNumber > _mediumNumber && _mediumNumber > _littleNumber)
        {
            Debug.Log("Los números están en orden decreciente");
        }
        else
        {
            Debug.Log("Introduce los números de forma decreciente");
        }
    }

    
}
