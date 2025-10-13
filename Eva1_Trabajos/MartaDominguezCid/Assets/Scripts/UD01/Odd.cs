using UnityEngine;

public class Odd : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetOddNumbersTo100();
    }

    private void GetOddNumbersTo100()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
            
        }
    }
            
}
