using UnityEngine;

public class MouseEvents : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Actuo cuando hago clic en el boton izq");
    }
    private void OnMouseOver()
    {
        Debug.Log("el raton sobre el collider");
    }
    private void OnMouseEnter()
    {
        Debug.Log("Cuando entro en el collider");
    }
    private void OnMouseExit()
    {
        Debug.Log("Cuando estoy fuera del collider");
    }
    private void OnMouseDrag()
    {
        Debug.Log("Cuando arrastro");
    }
}
