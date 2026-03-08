using UnityEngine;

public class EnemyMovementVitamini : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    //Puntos donde quiero que patrulle el enemy
    private Transform[] _pointsTransformArray;
    //posiciones de la patrulla, cojo la position de la. transform anterior
    private Vector2[] _pointsPositionArray;

    //velocidad de la hormiga
    
    private float _speed;
    [SerializeField]
    //velocidad de la hormiga
    private float _speedWalking;
    [SerializeField]
    private float _speedAttack;
    [SerializeField]
    private float _speedAmimation;
    [SerializeField]
    private float _distanceToPlayer;


    private Vector3 _posToGo;
    private int _index;
    private SpriteRenderer _spriteRenderer;
    private Animator _anim;
    [SerializeField]
    private GameObject _player;

    private void Awake()
    {
        _speed = _speedWalking;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();

        //Inicializamos el array de las posiciones con el tamaño del array de la transform para que sea igual.
        _pointsPositionArray = new Vector2[_pointsTransformArray.Length];
        for(int i = 0; i< _pointsTransformArray.Length; i++)
        {
            _pointsPositionArray[i] = _pointsTransformArray[i].position;
        }
        //coger el contenido de _pointsPositionArray del cajon cero y asignarselo
        _posToGo = _pointsPositionArray[0];

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position,_player.transform.position,Color.red);
        if(Vector2.Distance(transform.position, _player.transform.position) <= _distanceToPlayer)
        {
            AttackPlayer();
        }
        else
        {
           ChangeTargetPos(); 
        }
        

        //El movetowars cambia el valor de un vector hasta donde queramos 
        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);
        Flip();
    }

    private void ChangeTargetPos()
    {

        _speed =_speedWalking;
        _anim.speed = 1.0f;
        //Si hemos llegado a nuestro destino
        if(transform.position == _posToGo)
        {
           //volver al punto inicial si he llegado al ultimo
            if(_index == _pointsPositionArray.Length - 1)
            {
                _index = 0;
            }
            //si no llegue al ultimo continuo recorrido
            else
            {
                _index++;
            }
          
            //Estamos en el cajon 1 array 0
            _posToGo = _pointsPositionArray[_index];
        }
    }

    private void Flip()
    {
        if(_posToGo.x > transform.position.x)
        {
            _spriteRenderer.flipX = true;

        }
        else if(_posToGo.x < transform.position.x)
        {
            _spriteRenderer.flipX = false;
        }
            
        
    }
    public void AttackPlayer()
    {
        _speed = _speedAttack;
        //Si ve al player aumente su velocidad
        _anim.speed = _speedAmimation;
        _posToGo = new Vector2(_player.transform.position.x,_posToGo.y);
    }

    private void OnCollisionEnter2D(Collision2D infoCollision)
    {
        if(infoCollision.collider.CompareTag("Player") &&
         infoCollision.collider.GetComponent<VitaminiMovement>().IsGrounded)
        {
            infoCollision.collider.GetComponent<VitaminiHealth>().TakeDamage(20.0f);
        }
    }
}
