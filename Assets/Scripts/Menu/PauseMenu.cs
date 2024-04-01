using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    private FirstPersonMovement _player;
    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject _optionsPanel;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<FirstPersonMovement>();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        if (!GameObject.FindGameObjectWithTag("Quest")){
            _player.Activate();

        }
        gameObject.SetActive(false);
    }

    public void Options()
    {
        _mainPanel.SetActive(false);
        _optionsPanel.SetActive(true);
    }

    public void Back()
    {
        _mainPanel.SetActive(true);
        _optionsPanel.SetActive(false);
    }
}
