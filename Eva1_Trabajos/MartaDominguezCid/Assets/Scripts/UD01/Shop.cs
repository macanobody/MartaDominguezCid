using UnityEngine;

public class Shop : MonoBehaviour
{
    // Stock 
    [SerializeField]
    private int _brecol,
               _patatas;

    // El usuario decide qué hacer
    [SerializeField] 
    private bool _isAddition,
              _isSubtraction;

    // El usuario decide cuánto añadir o restar

    [SerializeField] 
    private int _amountBrecol,
                _amountPatatas;

    void Start()
    {
        LetsShop();
    }

    private void LetsShop()
    {
        if (_isAddition && !_isSubtraction)
        {
            AddProducts(_amountBrecol, _amountPatatas);
        }
        else if (_isSubtraction && !_isAddition)
        {
            SubtractProducts(_amountBrecol, _amountPatatas);
        }
        else
        {
            Debug.Log("Debes seleccionar solo sumar o restar.");
        }
    }

    private void AddProducts(int addBrecol, int addPatatas)
    {
        _brecol += addBrecol;
        _patatas += addPatatas;

        Debug.Log("Has añadido productos.");
        Debug.Log("Brécol total: " + _brecol);
        Debug.Log("Patatas total: " + _patatas);
        Debug.Log("Total productos en tienda: " + (_brecol + _patatas));
    }

    private void SubtractProducts(int subBrecol, int subPatatas)
    {
        // Evitar stock negativo
        if (subBrecol > _brecol)
        {
            Debug.Log("No puedes restar " + subBrecol + " brécol (solo hay " + _brecol + ")");
            return;
        }

        if (subPatatas > _patatas)
        {
            Debug.Log("No puedes restar " + subPatatas + " patatas (solo hay " + _patatas + ")");
            return;
        }

        _brecol -= subBrecol;
        _patatas -= subPatatas;

        Debug.Log("Has restado productos.");
        Debug.Log("Brécol total: " + _brecol);
        Debug.Log("Patatas total: " + _patatas);
        Debug.Log("Total productos en tienda: " + (_brecol + _patatas));
    }
}