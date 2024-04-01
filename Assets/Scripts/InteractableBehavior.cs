using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBehavior : MonoBehaviour
{
    private FirstPersonMovement _player;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<FirstPersonMovement>();
    }


    public void OnEnable()
    {
        _player.Deactivate();
    }

    public void OnDisable()
    {
        _player.Activate();
    }
}
