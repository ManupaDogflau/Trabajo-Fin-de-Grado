using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private GameObject _interactableWarning;
    private bool _onTrigger = false;

    private void Awake()
    {
        _interactableWarning = Resources.Load<GameObject>("InteractableWarning");
        _interactableWarning = Instantiate(_interactableWarning, Vector3.zero, Quaternion.identity, transform);
        _interactableWarning.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        //Activar Prueba
        _interactableWarning.SetActive(true);
        _onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //Desactivar Prueba
        _interactableWarning.SetActive(false);
        _onTrigger = false;
    }

    public void Activate()
    {
        if (_onTrigger == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneLoader.Load(SceneLoader.SceneName.End);
        }
    }
}
