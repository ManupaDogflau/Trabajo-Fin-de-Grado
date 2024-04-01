using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    private Text _text;
    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    void Start()
    {
       _text.text= DateTime.Now.ToString("dd/MM/yyyy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
