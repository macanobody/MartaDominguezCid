using UnityEngine;

public class BallPinkGirl : MonoBehaviour
{
    /*  [SerializeField]
      private Material _mat;
      private void OnCollisionEnter(Collision infoCollision)
      {
          Debug.Log("He colisionado con algoo " + infoCollision.gameObject.name);
          //voy a ver si estoy chocando contra el cubo
          //accedo al collider con el que choca la bala y miro la etiqueta enemy
          if (infoCollision.collider.CompareTag("Enemy"))
          {
              //cambio color material cubo al darle con la bola
              //accedo a su componente renderer y a su material
              infoCollision.gameObject.GetComponent<Renderer>().material = _mat;
          }
      }
      */
    private void OnTriggerEnter(Collider infoAcces)
    {
        Debug.Log("Estoy colisionando con " + infoAcces.gameObject.name);
        if (infoAcces.CompareTag("Enemy"))
        {
            //Este infoAccess hace referencia al cubo por la etiqueta enemy
            Destroy(infoAcces.gameObject);
        }
    }
}
