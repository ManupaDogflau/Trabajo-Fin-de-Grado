using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandableWindow : MonoBehaviour
{
    [SerializeField] private GameObject _panel, _symbol;
    private bool _expanded=false; 

    public void Expand_Collapse()
    {
        if (_expanded)
        {
            Collapse();
            _expanded = false;
        }
        else
        {
            Expand();
            _expanded = true;
        }
    }

    private void Collapse()
    {
        _panel.SetActive(false);
        _symbol.transform.Rotate(0, 0, 180);
    }
    private void Expand()
    {
        _panel.SetActive(true);
        _symbol.transform.Rotate(0, 0, 180);
    }
}
