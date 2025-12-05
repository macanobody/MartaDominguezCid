using UnityEngine;

public class Clon : MonoBehaviour
{
    //zona de variables globales
    [SerializeField]
    private GameObject _acorn;
    [SerializeField]
    private Transform _postRotSquirrel;
    [SerializeField]
    private float _thrustY,
                  _thrustZ;
    [SerializeField]
    private float _timeDestroy;

    // Update is called once per frame
    void Update()
    {
        
        CreateAcorns();

    }

    private void CreateAcorns()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //instanciamos prefabs
            GameObject cloneAcorn = Instantiate(_acorn, _postRotSquirrel.position, _postRotSquirrel.rotation);
            //el componente rigidbody es el de los clones de la bellota
            Rigidbody rbAcorn = cloneAcorn.GetComponent<Rigidbody>();
            //destruir la bellota
            Destroy(cloneAcorn, _timeDestroy);
            //aplicamos fuerza hacia arriba
            rbAcorn.AddForce(Vector3.up * _thrustY);
            //aplicamos fuerza hacia delante
            rbAcorn.AddForce(transform.forward * _thrustZ);
        }
    }
}
