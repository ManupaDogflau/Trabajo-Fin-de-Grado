using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{
    [SerializeField] private string _url;
    private Transform _button;
    [SerializeField] private int _activationId;

    private void Awake()
    {
        if (transform.childCount == 0) return;
        _button = transform.GetChild(0);
    }

    public void OpenURL()
    {
        Utils.OpenURL(_url);
    }

    public void Activate(ItemCheckedEvent itemCheckedEvent)
    {
        if (itemCheckedEvent.element==_activationId)
        _button.gameObject.SetActive(true);
    }
}
