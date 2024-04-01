using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Runtime.InteropServices;
using System;



public class VideoManager : MonoBehaviour
{
    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    private VideoPlayer _video;
    [SerializeField] private GameObject _menuPanel;
    private long _totalFrame;
    private float _time = 2;


    private void Start()
    {
        _video = GetComponent<VideoPlayer>(); 
        //InvokeRepeating("checkEnd", .1f, .1f);
        _totalFrame = (long)_video.frameCount;
    }

    private void checkEnd()
    {
        long currentFrame = _video.frame;
        

        if (currentFrame < _totalFrame)
        {
            return;
        }
        
        _menuPanel.SetActive(true);
        gameObject.SetActive(false);
        CancelInvoke("checkEnd");
    }

    private void Update()
    {
        _time -= Time.deltaTime;
        if (_time > 0)
            return;
        if (Input.GetKeyDown(KeyCode.Escape) || !_video.isPlaying)
        {
            _menuPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
