using UnityEngine;

public class ComponentGet : MonoBehaviour
{
    //Zona de variables globales
    private Light _myLight;
    [SerializeField]
    private BoxCollider _myCubeCollider;

    private void Awake()
    {
        //Inicialización del componente Light porque mi gameObject tiene este componente
        _myLight = GetComponent<Light>();
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _myLight.enabled = false;
        _myCubeCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
