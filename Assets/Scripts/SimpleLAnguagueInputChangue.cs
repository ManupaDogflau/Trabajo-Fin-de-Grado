using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleLAnguagueInputChangue : MonoBehaviour
{

    [SerializeField] private string[] _languagues;

    private void OnEnable()
    {
        OptionScriptable options = Resources.Load<OptionScriptable>("Options");
        InputField text = GetComponent<InputField>();
        text.text = _languagues[options.languagueId];
    }
}

