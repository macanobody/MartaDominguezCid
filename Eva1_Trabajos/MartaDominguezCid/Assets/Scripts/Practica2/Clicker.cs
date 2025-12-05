using UnityEngine;

public class Clicker : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    //Crear fuerza
    private float _thrust;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        _rb.AddForce(transform.up * _thrust);
    }
}
