using UnityEngine;

public class MovementPinkGirl : MonoBehaviour
{
    //Zona de variables globales

    [SerializeField]
    private float _speed,
                _turnSpeed;
    private float _horizontal;
    private float _vertical;


    // Update is called once per frame
    void Update()
    {
        InputsPlayer();
        Move();
        Turn();
    }
    private void InputsPlayer()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
    }
    private void Turn()
    {
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
    }
}
