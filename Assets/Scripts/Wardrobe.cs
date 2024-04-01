using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    [SerializeField] private GameObject _battery;
    private TelephoneMessageEvent _telephoneMessageChanger;
    private bool _activated = false;
    public void Start()
    {
        if (!_activated)
        {
            _battery.SetActive(false);
            _telephoneMessageChanger = Resources.Load<TelephoneMessageEvent>("TelephoneMessageEvent");
            _telephoneMessageChanger.Fire();
            _activated = true;
        }
    }

}
