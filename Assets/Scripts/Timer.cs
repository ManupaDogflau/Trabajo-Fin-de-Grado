using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _startingTime = 45 * 60;
    [SerializeField] private Text _text;
    [SerializeField] private GameObject _message;
    private float _realTime;

    private void Awake()
    {
        _realTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        float time = _startingTime - Time.realtimeSinceStartup + _realTime;
        int timeint = Mathf.FloorToInt(time);
        int seconds = timeint;
        if (seconds < 0)
        {
            seconds = 0;
        }
        int minute = seconds / 60;
        seconds = seconds % 60;
        string a = seconds.ToString("##");
        if (seconds < 10)
        {
            a = "0" + seconds.ToString("##");
            if (seconds == 0)
            {
                a = "00";
            }
        }
        string b = minute.ToString("##");
        if (minute < 10)
        {
            b = "0" + minute.ToString("##");
            if (minute == 0)
            {
                b = "00";
            }
        }
        _text.text = (b + ":" + a);

        if (minute <= 0 && seconds <= 0)
        {
            _message.SetActive(true);
        }
    }
}
