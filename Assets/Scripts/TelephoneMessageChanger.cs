using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneMessageChanger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        TelephoneMessageEvent telephoneMessageEvent = Resources.Load<TelephoneMessageEvent>("TelephoneMessageEvent");
        telephoneMessageEvent.Fire();
        Destroy(gameObject);
    }
}
