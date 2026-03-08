using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VitaminiMovement : MonoBehaviour
{
    //Zona de variables globales
    [Header("Velocity")]
    [SerializeField]
    private float _speed;
    //tiempo que tarda en alcazar la velocidad
    [SerializeField]
    private float _smoothTime;

    public Rigidbody2D Rb;
    private Animator _anim;
    private SpriteRenderer _spriteRenderer;
    //velocidad a la que quiero mover el personaje
    private Vector2 _targetVelocity;
    private Vector2 _dampVelocity;

    [Header("Jump")]
    [SerializeField]
    private float _jumpForce;
    private bool _jumpPressed;
    [Header("Raycast")]
    //Punto de origen
    [SerializeField]
    private Transform _groundCheck;
    //capa del suelo
    [SerializeField]
    private LayerMask _groundLayer;
    [SerializeField]
    //Longitud del rayo
    private float _rayLength;
    //Estamos tocando el suelo

    [Header("Acorn")]
    [SerializeField]
    private int _numAcorn;
    [SerializeField]
    private TextMeshProUGUI _textAcornUI;
   
    public bool IsGrounded;

    private void Awake()
    {
        _textAcornUI.text = "Bellotas perdidas: " + _numAcorn.ToString();
        _jumpPressed = false;
        Rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
       CanJump();
       RaycastGrounded();
       ChangeGravity();
    }
    private void CanJump()
    {
        if(_jumpPressed == true)
        {
            Jump();
        }
    }
    private void RaycastGrounded()
    {
        IsGrounded = Physics2D.Raycast(_groundCheck.position, Vector2.down, _rayLength, _groundLayer);
        Debug.DrawRay(_groundCheck.position, Vector2.down * _rayLength, Color.red);
    }
    private void Jump()
    {
        _jumpPressed = false;
        Rb.AddForce(Vector2.up * _jumpForce);
    }

    private void ChangeGravity()
    {
        if(Rb.linearVelocity.y < 0.0f)
        {
            Rb.gravityScale = 1.5f;
        }
        else
        {
            Rb.gravityScale = 1.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        InputsPLayer();
       
    }

    private void InputsPLayer()
    {
        //teclas que voy a utilizar en eje X (A,D <,>)
        float horizontal = Input.GetAxis("Horizontal");
        _targetVelocity = new Vector2(horizontal * _speed, Rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded == true)
        {
            _jumpPressed = true;
        }

        Flip(horizontal);
       Animating(horizontal);
    }

    public void ResetVelocity()
    {
        //paro al player reseteando velocidad
        _targetVelocity = Vector2.zero;
    }
    private void Move()
    {
        Rb.linearVelocity = Vector2.SmoothDamp(Rb.linearVelocity,_targetVelocity, ref _dampVelocity, _smoothTime);
    }
    private void Animating(float h)
    {
        if(h != 0.0f)
        {
            _anim.SetBool("IsRunning", true);
        }
         else
        {
        _anim.SetBool("IsRunning", false);
        }

        _anim.SetBool("IsJumping", !IsGrounded);
    }
    private void Flip(float h)
    {
        
        if(h > 0.0f)
        {
            _spriteRenderer.flipX = false;
        }
        else if (h < 0.0f)
        {
            _spriteRenderer.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D infoCollision)
    {
        if (infoCollision.collider.CompareTag("Acorn"))
        {
            Destroy(infoCollision.collider.gameObject);
            _numAcorn--;
            _textAcornUI.text = "Bellotas perdidas: " + _numAcorn.ToString();

            if(_numAcorn == 0)
            {
                GetNewScene();
            }
        }
    }
    private void GetNewScene()
    {
        SceneManager.LoadScene("Vitamini");
    }
   
}
