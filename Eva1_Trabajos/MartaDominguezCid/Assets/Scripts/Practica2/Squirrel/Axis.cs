using UnityEngine;

public class Axis : MonoBehaviour
{
    // zona de variables globales
    [SerializeField]
    private float _speed = 1.0f,
                  _turnSpeed = 70.0f;
    private float _horizontal,
                  _vertical;

    // Update is called once per frame
    void Update()
    {
        InputCube();
    }
    private void InputCube()
    {
        //Asignar A, D, <, > al eje horizontal
        _horizontal= Input.GetAxis("Horizontal");
        //Asignar W, S ^ y V al eje vertical
        _vertical= Input.GetAxis("Vertical");
        //Aplicar movimiento rotacion
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
        //Aplicar movimiento translacion
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
    }
}
