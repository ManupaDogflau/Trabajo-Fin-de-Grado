using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] protected float _distance;
    protected float _startPosition;
    [SerializeField] protected float _speed = 1;
    [SerializeField] private int _doorId;
    private bool _opening = false;
    [SerializeField]  AudioClip _clip;
    // Start is called before the first frame update

    private void Start()
    {
        _startPosition = transform.position.x;
    }

    public void Update()
    {
        if (_opening)
        {
            Opening();
        }
    }

    public virtual void Opening()
    {
        if (transform.position.x <= _startPosition + _distance)
        {
            transform.position += new Vector3(Time.deltaTime * _speed, 0, 0);
        }
    }

    public void Open(OpenDoorEvent openDoorEvent)
    {
        if (openDoorEvent.doorId == _doorId)
        {
            _opening = true;
            SoundEmitter.Instance().PlaySFX(_clip);
        }
    }
}
