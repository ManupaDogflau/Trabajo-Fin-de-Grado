using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private AudioClip a;
    // Start is called before the first frame update
    void Start()
    {
        SoundEmitter.Instance().PlayMusic(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
