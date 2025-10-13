using UnityEngine;

public class Rectangle : MonoBehaviour
{
    //Variables globales
    //Ejercicio rectángulo

    private float _width;
    private float _height;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _width = 12.5f;
        _height = 6.1f;

        GetArea();
        GetPerimeter();
        GetDiagonal();
    }

    private void GetArea()
    {
        //variables locales
        float area = 0.0f;

        //calcular el área
        area = _width * _height;

        //mostrar por consola el resultado del área.

        Debug.Log("El área de mi rectágulo es:  " + area);


    }
    private void GetPerimeter()
    {
        //zona de variables locales
        float perimeter = 0.0f;

        //calcular perimetro
        perimeter = 2 * (_width * _height);

        //mostrar por consola
        Debug.Log("El perímetro de mi rectángulo es: " + perimeter);

    }
    private void GetDiagonal()
    {
        //Zona de variables locales
        float diagonal = 0.0f;

        //Calcular diagonal

        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        //Mostrar la diagonal del rectángulo

        Debug.Log("La longitud de la diagonal del rectángulo es: " + diagonal);

    }


}
