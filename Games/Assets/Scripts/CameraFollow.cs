using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform _player;
    //Distancia inicial entre camera y player
    private Vector3 _offset;

    [SerializeField]
    //tiempo que tarda en llegar la camara al player
    private float _smoothTargetTime;

    //velocidad a la que va el vector
    private Vector3 _smoothDampVelocity;

    private void Awake()
    {
        //calculo distancia inicial entre camara y player
        _offset = transform.position - _player.position;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }
    private void MoveCamera()
    {
        transform.position = Vector3.SmoothDamp(transform.position, _player.position + _offset,
                                                ref _smoothDampVelocity, _smoothTargetTime);
    }
}
