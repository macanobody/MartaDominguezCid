using UnityEngine;

public class LookRabbit : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private Transform _target;
    [Header("Vectors")]
    //velocidad de seguimiento de la cámara
    [SerializeField]
    private float _smoothig;
    //Distancia entre la camara y el conejo
    [SerializeField]
    private Vector3 _offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //posicion camara - posicion conejo
        _offset = transform.position - _target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Posicion a la que mover la camara
        Vector3 desiredPosition = _target.position + _offset;
        //Lerpear camara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothig * Time.deltaTime);
    }
}
