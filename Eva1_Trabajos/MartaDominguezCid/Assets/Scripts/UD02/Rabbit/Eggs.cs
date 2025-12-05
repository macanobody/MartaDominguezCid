using UnityEngine;

public class Eggs : MonoBehaviour
{
   //Zona de variables globales
   [Header("Elements")]
   [SerializeField]
   //Punto de lanzamiento
   private Transform _posRot;
   [SerializeField]
   //Objeto del lanzamiento
   private GameObject _eggs;
   
   //Fuerza del lanzamiento
   [Header("Physics")]
   [SerializeField]
   private float _thrustY,
                _thrustZ;
    private float _timeDestroy = 3.0f;

    // Update is called once per frame
    void Update()
    {
        InputCreateEggs();
    }
    private void CreateEggs()
    {
        //Instanciar clon de objeto y obtener la posicion y rotacion del lanzamiento.
        GameObject cloneEggs = Instantiate(_eggs, _posRot.position, _posRot.rotation);
        //Componente Rb con el que voy a trabajar
        Rigidbody rbCloneeggs = cloneEggs.GetComponent<Rigidbody>();
        //Añadir fuerza a la Y global de la escena
        rbCloneeggs.AddForce(Vector3.up * _thrustY);
        //Añadir fuerza a la Z global de la escena
        rbCloneeggs.AddForce(Vector3.forward * _thrustZ);
        Destroy(cloneEggs, _timeDestroy);
    }
    //Al clickar boton izq del raton lanza el huevo
    private void InputCreateEggs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateEggs();
        }
    }
}
