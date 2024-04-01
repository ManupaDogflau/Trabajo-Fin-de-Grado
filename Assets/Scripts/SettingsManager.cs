using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    private OptionScriptable _optionScriptable;
    [SerializeField] private  Slider _musicSlider, _sfxSlider;
    [SerializeField] private Toggle _musicToggle, _sfxToggle;
    [SerializeField] private Toggle _spanishToggle, _euskeraToggle;
    private int _actualLanguague;
    public void Awake()
    {
        _optionScriptable = Resources.Load<OptionScriptable>("Options");
        _actualLanguague = _optionScriptable.languagueId;
    }
    // Start is called before the first frame update
    void Start()
    {
        _musicSlider.value = _optionScriptable.musicVolume;
        _musicToggle.isOn = _optionScriptable.musicBool;
        _sfxSlider.value = _optionScriptable.sfxVolume;
        _sfxToggle.isOn = _optionScriptable.sfxBool;
        if (_optionScriptable.languagueId==0)
        {
            _spanishToggle.isOn = true;
            _euskeraToggle.isOn = false;
        }
        else
        {
            _spanishToggle.isOn = false;
            _euskeraToggle.isOn = true;
        }
    }

    public void changeLanguague()
    {
        _actualLanguague = _actualLanguague == 0 ? 1 : 0;
        _optionScriptable.languagueId = _actualLanguague;
       
    }
}


