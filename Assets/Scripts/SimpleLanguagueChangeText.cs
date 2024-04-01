using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleLanguagueChangeText : MonoBehaviour
{
    [SerializeField] private string[] _languagues;

    private void OnEnable()
    {
        OptionScriptable options=Resources.Load<OptionScriptable>("Options");
        Text text = GetComponent<Text>();
        text.text = _languagues[options.languagueId];
    }
}
