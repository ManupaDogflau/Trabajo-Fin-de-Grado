using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimationChanger : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > -19)
            _animator.SetBool("B", true);
    }
}
