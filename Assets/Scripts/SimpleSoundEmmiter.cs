using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSoundEmmiter : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    void OnEnable()
    {
        SoundEmitter.Instance().PlaySFX(_clip);
    }

    
}
