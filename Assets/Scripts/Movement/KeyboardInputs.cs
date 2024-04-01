using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputs : MonoBehaviour
{
    [SerializeField] private FirstPersonMovement _movement;


    private Dictionary<Bindings,KeyCode> _bindings= new Dictionary<Bindings, KeyCode>();

    private void Awake()
    {
        _bindings.Add(Bindings.forward, KeyCode.W);
        _bindings.Add(Bindings.back, KeyCode.S);
        _bindings.Add(Bindings.left, KeyCode.A);
        _bindings.Add(Bindings.right, KeyCode.D);
        _bindings.Add(Bindings.jump, KeyCode.Space);
        _bindings.Add(Bindings.telephone, KeyCode.T);
        _bindings.Add(Bindings.interact, KeyCode.I);
        _bindings.Add(Bindings.pause, KeyCode.Escape);
    }

    private void Update()
    {
        float movez=0, movex=0;
        if (Input.GetKey(_bindings[Bindings.forward]))
        {
            movez = 1;
        }

        if (Input.GetKey(_bindings[Bindings.back]))
        {
            movez = -1;
        }

        if (Input.GetKey(_bindings[Bindings.left]))
        {
            movex = -1;
        }

        if (Input.GetKey(_bindings[Bindings.right]))
        {
            movex = 1;
        }

        if (Input.GetKeyDown(_bindings[Bindings.jump]))
        {
            _movement.Jump();
        }
        _movement.Move(movex, movez);

         float rotatex, rotatey;
        
        rotatex = Input.GetAxisRaw("Mouse X");
        rotatey = Input.GetAxisRaw("Mouse Y");

        _movement.Rotate(rotatex, rotatey);

        if (Input.GetKeyDown(_bindings[Bindings.telephone]))
        {
            _movement.Telephone();
        }
        if (Input.GetKeyDown(_bindings[Bindings.interact]))
        {
            _movement.Interact();
        }
        if (Input.GetKeyDown(_bindings[Bindings.pause]))
        {
            _movement.Pause();
        }
    }
}

