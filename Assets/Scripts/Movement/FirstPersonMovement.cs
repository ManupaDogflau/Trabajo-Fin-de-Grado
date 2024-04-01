    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{

    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _sensitivity;

    private TelephoneCallEvent _telephone;
    private Rigidbody _rigidbody;
    private bool _isGrounded;
    private bool _isActivated;
    private Camera _camera;
    private GameObject _pause;
    private InteractEvent _interact;

    private float _xRotation = 0f;
    [SerializeField] private AudioClip[] _step;

    private float _maxCounter=0.4f;
    private float _counter = 0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _isActivated = true;
        _telephone = Resources.Load<TelephoneCallEvent>("TelephoneCallEvent");
        _interact = Resources.Load<InteractEvent>("InteractEvent");
        _camera = Camera.main;
    }

    private void Start()
    {
        _pause = GameObject.Find("PauseMenu").transform.GetChild(0).gameObject;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        _counter -= Time.deltaTime;
    }

    public void Rotate(float x, float y)
    {
        if (!_isActivated) return;
        float _yRotation = x * _sensitivity * Time.deltaTime;
        _xRotation -= y * _sensitivity* Time.deltaTime;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        transform.Rotate (Vector3.up* _yRotation);
        _camera.transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
    }

    public void Move(float x, float z)
    {
        if (!_isActivated) return;
        transform.Translate(new Vector3(x* _movementSpeed * Time.deltaTime,0, z*_movementSpeed *Time.deltaTime));
        if ((x != 0 || z != 0) && _counter <= 0) 
        {
            SoundEmitter.Instance().PlaySFX(_step[Random.Range(0,_step.Length)]);
            _counter = _maxCounter;
        }
    }

    public void Jump()
    {
        if (!_isActivated) return;
        if (_isGrounded)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }

    public void Deactivate()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _isActivated = false;
    }

    public void Activate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _isActivated = true;
    }

    public void Telephone()
    {
        _telephone.Fire();
    }

    public void Interact()
    {
        _interact.Fire();
    }

    public void Pause()
    {
        _pause.SetActive(true);
        Deactivate();
    }
}

public enum Bindings
{
    forward,
    back,
    left,
    right,
    jump,
    telephone,
    interact,
    pause,
}
