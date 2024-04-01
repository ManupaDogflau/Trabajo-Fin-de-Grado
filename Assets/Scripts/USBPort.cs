using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBPort : MonoBehaviour
{
    [SerializeField] private GameObject _usbPort;
    [SerializeField] private int _id = 3;
    [SerializeField] private int _element;
    private OpenDoorEvent _openDoorEvent;
    // Start is called before the first frame update
    void Start()
    {
        _openDoorEvent = Resources.Load<OpenDoorEvent>("OpenDoorEvent");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate(OpenDoorEvent openDoorEvent)
    {
        if (openDoorEvent.doorId == _id)
        {
            _usbPort.SetActive(true);
        }
    }

    public void OpenFinalDoor(ItemCheckedEvent itemCheckedEvent)
    {
         if (itemCheckedEvent.element == _element)
        {
            _openDoorEvent.doorId = 4;
            _openDoorEvent.Fire();
        }
    }
}
