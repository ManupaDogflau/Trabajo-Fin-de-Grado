using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{

    
    [SerializeField] private string _correctAnswer;
    [SerializeField] private Image _image;
    [SerializeField] private int _doorId;
    [SerializeField] private AudioClip _wrong, _correct;
    private OpenDoorEvent _event;

    private void Awake()
    {
        _event = Resources.Load<OpenDoorEvent>("OpenDoorEvent");
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }



    public void CompareResult(string answer )
    {
        if (string.Equals(answer.ToUpper(), _correctAnswer))
        {
            _event.doorId = _doorId;
            _event.Fire();
            _image.color = Color.green;
            SoundEmitter.Instance().PlaySFX(_correct);
        }
        else
        {
            SoundEmitter.Instance().PlaySFX(_wrong);
        }
    }
}
