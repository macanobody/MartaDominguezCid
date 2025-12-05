
using UnityEngine;

public class AttackPinkGirl : MonoBehaviour
{
    //Zona de variables globales
    [Header("Elements")]
    [SerializeField]
    private Transform _posRot;
    [SerializeField]
    private GameObject _ball;
    //Crear fisicas de lanzamiento
    [Header("Physics")]
    [SerializeField]
    private float _thrustY,
                _thrustZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  

    // Update is called once per frame
    void Update()
    {
        InputCreateBalls();
        
    }
    private void CreateBalls()
    {
        GameObject cloneball = Instantiate(_ball, _posRot.position, _posRot.rotation);
        //El componente rigidbody con el que voy a trabajar. Es el clon de las bolas
        Rigidbody rbCloneBall = cloneball.GetComponent<Rigidbody>();
        //Referencia a la Y global de la escena
        rbCloneBall.AddForce(Vector3.up * _thrustY);
        //Hace referencia al eje z local del posRot
        rbCloneBall.AddForce(Vector3.forward * _thrustZ);
    }

    private void InputCreateBalls()
    {
       if (Input.GetMouseButtonDown(0))
        {
            CreateBalls();
        }
    }

}
