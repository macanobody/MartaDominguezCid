using UnityEngine;

public class CylinderArea : MonoBehaviour
{
    //zona de variables globales

    private float _radius;
    private float _height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _radius = 2.3f;
        _height = 5.2f;
        GetArea();
        GetVolume();


    }

    private void GetArea()
    {
        //zona de variables locales
        float area = 0.0f;

        //calcular area
        area = (2 * (Mathf.PI * Mathf.Pow(_radius, 2)) + 2 * Mathf.PI * _radius * _height);

        //Mostrar por consola el area

        Debug.Log("El área del cilindro es: " + area);




    }

    private void GetVolume()
    {
        //zona de variables locales
        float volume = 0.0f;

        //calcular volumen

        volume = Mathf.PI * Mathf.Pow(_radius, 2) * _height;

        //Mostrar por consola el volumen

        Debug.Log("El volumen del cilindro es: " + volume);
    }
    
}
