using UnityEngine;

public class Weight : MonoBehaviour
{
    [SerializeField]
    private float _g,
                 _oz,
                 _lb,
                 _kg;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetPounds();
        GetOunce();
        GetKilograms();

    }
    private void GetPounds()
    {
        /*calcular de gramos a libras
         _g = 1.0f;
        _lb = 0.0022f;*/

        _lb = _g * 0.0022f;
      

        //mostras en consola
        Debug.Log(_g + " gramos son" + _lb + " libras");


    }
    private void GetOunce()
    {
        /*calcular de gramos a onzas
        _g = 1.0f;
        _oz = 0.0353f;*/

        _oz = _g * 0.03527396f;

        //mostrar en consola
        Debug.Log(_g + " gramos son" + _oz + " onzas");

    }
    private void GetKilograms()
    {
        /*calcular de gramos a kilogramos
        _g = 1.0f;
        _kg = 0.001f;*/

        _kg = _g * 0.001f;

        //mostrar en consola
        Debug.Log(_g + " gramos son" + _kg + " kilogramos");

    }

}
