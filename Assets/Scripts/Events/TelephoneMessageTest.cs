using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneMessageTest : MonoBehaviour
{
    private TelephoneMessageEvent _telephone;
    private void Start()
    {
       _telephone= Resources.Load<TelephoneMessageEvent>("TelephoneMessageEvent");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            _telephone.Fire();
        }
    }
}
