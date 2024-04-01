using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject _creditsPanel, _mainPanel, _howToPlayPanel, _optionsMenu;
    public void Play()
    {
        SceneLoader.Load(SceneLoader.SceneName.Game);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        _creditsPanel.SetActive(false);
        _howToPlayPanel.SetActive(true);
        _mainPanel.SetActive(false);
        _optionsMenu.SetActive(false);
    }

    public void Credits()
    {
        _creditsPanel.SetActive(true);
        _howToPlayPanel.SetActive(false);
        _mainPanel.SetActive(false);
        _optionsMenu.SetActive(false);
    }

    public void Options()
    {
        _creditsPanel.SetActive(false);
        _howToPlayPanel.SetActive(false);
        _mainPanel.SetActive(false);
        _optionsMenu.SetActive(true);
    }

    public void Back()
    {
        _creditsPanel.SetActive(false);
        _howToPlayPanel.SetActive(false);
        _mainPanel.SetActive(true);
        _optionsMenu.SetActive(false);
    }
    
}
