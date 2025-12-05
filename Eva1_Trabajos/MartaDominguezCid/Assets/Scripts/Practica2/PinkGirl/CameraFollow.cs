using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //zona de variables globales
    [SerializeField]
    private Transform _target;
    [Header("Vectors")]
    //velocidad seguimiento de la camara
    [SerializeField]
    private float _smoothing;
    //Distancia inicial que hay entre camara y player
    [SerializeField]
    private Vector3 _offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //posicion de la camara y le restamos la posicion del player
        _offset = transform.position - _target.position;
    }
    //Utilizamos el lateupdate porque queremos que vaya mas tarde que el movimiento del player
    private void LateUpdate()
    {
        //Posicion a la que queremos mover la camara

        Vector3 desiredPosition = _target.position + _offset;

        //mover la camara
        //Lerp = interpolacion para movimiento suave
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);
    }
}
