
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private int _pointPlayer;

    void Start()
    {
        IncreaseUntil45(_pointPlayer);
    }
    private void IncreaseUntil45(int points)
    {
        for (int i = points; i <= 45; i++)
        {
            Debug.Log("Puntos actuales: " + i);

            if (i == 45)
            {
                Debug.Log("Ganador, el jugador ha alcanzado 45 puntos");
            }
        
            
        }
            
        
    }
}