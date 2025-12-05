using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
   
   //Zona de variables globales
   [Header("Move")]
   [SerializeField]
   private float _speed,
             _turnSpeed;
    private float _horizontal,
                    _vertical;
    //Animacion de movimiento
    private Animator _anim;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLength;
    [SerializeField]
    private LayerMask _rayMask;

    private Rigidbody _rb;
    [SerializeField]
    private float _forceJump;
    private bool _isGrounded;
    private bool _canJump;

    private void Awake()
    {
        //Mi variable _anim obtiene animator del gameObject
        _anim =GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        LaunchRaycast();
        if (_canJump == true)
        {
            _canJump = false;
            Jump();
        }
    }
    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        Move();
        Turn();
        Animating();
        CanJump();
     
    }
    private void Jump()
    {
        _rb.AddForce(Vector3.up * _forceJump);
    }
    private void LaunchRaycast()
    {
        _ray.origin = transform.position;
        _ray.direction = -transform.up;
        if(Physics.Raycast(_ray,out _hit, _rayLength, _rayMask))
        {
            Debug.Log("Estoy tocando el suelo");
            _isGrounded = true;

        }
        else
        {
            _isGrounded = false;
        }
         Debug.DrawRay(_ray.origin, _ray.direction * _rayLength, Color.red);
    }
    private void CanJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _canJump = true;
        } 
    }
    private void InputPlayer()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
    }
    private void Turn()
    {
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);
    }
    private void Animating()
    {
        if(_vertical != 0)//el personaje se mueve
        {
            _anim.SetBool("isMoving",true);
        }
        else//el personaje esta parado
        {
            _anim.SetBool("isMoving",false);
        }
    }
}
