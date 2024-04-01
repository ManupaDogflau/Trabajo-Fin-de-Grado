using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Options", fileName = "Options")]
public class OptionScriptable : ScriptableObject
{
    public int languagueId;
    public bool musicBool;
    public bool sfxBool;
    public float musicVolume;
    public float sfxVolume;
}
