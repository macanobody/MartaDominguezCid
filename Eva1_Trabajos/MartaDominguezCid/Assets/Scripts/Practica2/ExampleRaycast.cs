using UnityEngine;

public class ExampleRaycast : MonoBehaviour
{
    //Zona de variables globales
    //Variable informacion del rayo
    private Ray _ray;
    //guardar info del choque entre raycast y collider del gameObject
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLength;
    [SerializeField]
    private LayerMask _enemyRay;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ray.origin = transform.position;
        //direccion hacia donde mira pinkgirl
        _ray.direction = transform.forward;

        //usamos out para sacar fuera la informacion de _hit
        if (Physics.Raycast(_ray, out _hit, _rayLength, _enemyRay))
        {
            Debug.Log("Estoy chocando con algo" + _hit.collider.name);
            Debug.Log("Punto del impacto: " + _hit.point);
            Debug.Log("distancia: " + _hit.distance);

            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * 300.0f);
            
        }
        Debug.DrawLine(_ray.origin, _ray.direction * 10.0f, Color.red);

    }
}
