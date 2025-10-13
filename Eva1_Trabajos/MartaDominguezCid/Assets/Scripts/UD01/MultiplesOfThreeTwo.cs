using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetMultiplesOfThreeTwo();
    }

    private void GetMultiplesOfThreeTwo()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
            else if (i % 3 == 0)
            {
                Debug.Log(i);
            }
            
        }
    }
}
