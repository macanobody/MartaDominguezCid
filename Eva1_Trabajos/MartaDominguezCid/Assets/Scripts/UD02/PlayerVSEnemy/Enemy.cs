using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider infoAcces)
    {
        if (infoAcces.CompareTag("AttackPlayer"))
        {
            Destroy(gameObject);
        }
    }
}
