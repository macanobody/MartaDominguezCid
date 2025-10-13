using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
   [SerializeField]
   private int _numberOne,
                _numberTwo,
                _numberThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsDescending();
    }

    private void IsDescending()
    {
        if (_numberOne > _numberTwo && _numberTwo > _numberThree)
         {
             Debug.Log("El orden descendente de los números es: " + _numberOne + _numberTwo + _numberThree);
         }
         else if (_numberTwo > _numberOne && _numberOne > _numberThree)
         {
             Debug.Log("El orden descendente de los números es:  " + _numberTwo + _numberOne + _numberThree);

         }
         else if (_numberThree > _numberOne && _numberOne > _numberTwo)
         {
             Debug.Log("El orden descendente de los números es: " + _numberThree + _numberOne + _numberTwo);
         }
         else if (_numberTwo > _numberThree && _numberThree > _numberOne)
         {
             Debug.Log("El orden descendente de los número es: " + _numberTwo + _numberThree + _numberOne);
         }
         else if (_numberThree > _numberTwo && _numberTwo > _numberOne)
         {
             Debug.Log("El orden descendente de los números es: " + _numberThree + _numberTwo + _numberOne);
         }
         else if (_numberOne == _numberTwo && _numberTwo == _numberThree)
         {
             Debug.Log("Los números son iguales");
         }
         else
         {
             Debug.Log("Hay dos números iguales y uno distinto");
         } 

        
        
    } 
}
