using UnityEngine;

public class AttackPlayer : MonoBehaviour
{

    //Zona de variables globales
    private Animator _anim;
    [SerializeField]
    private Collider _colliderAttack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        InputAttack();
       
    }
    private void InputAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
            
        }
    }
    private void Attack()
    {
        _anim.SetTrigger("Attack");
    }
    private void OnEnableCollider()
    {
       // habilito el componente para el collider de la espada
        _colliderAttack.enabled = true;
    }
    private void OnDisableCollider()
    {
        _colliderAttack.enabled = false;
    }
}
