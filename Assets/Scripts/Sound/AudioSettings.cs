using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{

    private OptionScriptable _optionScriptable;
    public void Awake()
    {
        _optionScriptable=Resources.Load<OptionScriptable>("Options");
    }

    public void ChangeMusicVolume(float f)
    {
        SoundEmitter.Instance().ChangeMusicVolume(f);
        _optionScriptable.musicVolume = f;
    }

    public void ChangeSFXVolume(float f)
    {
        SoundEmitter.Instance().ChangeSFXVolume(f);
        _optionScriptable.sfxVolume = f;
    }
    public void ChangeMusicMute(bool b)
    {
        SoundEmitter.Instance().SetMusicMute(b);
        _optionScriptable.musicBool = b;
    }

    public void ChangeSFXMute(bool b)
    {
        SoundEmitter.Instance().SetSfxMute(b);
        _optionScriptable.sfxBool = b;
    }
}
