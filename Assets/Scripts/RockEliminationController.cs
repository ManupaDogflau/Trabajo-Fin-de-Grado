using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockEliminationController : MonoBehaviour
{
    [SerializeField] private GameObject _rock;
    [SerializeField] private GameObject _eliminate;
    [SerializeField] private Text _text;


    public void Activate()
    {
        if (Resources.Load<OptionScriptable>("Options").languagueId == 1)
            _text.text = "Zarata asko egiteagatik harrapatu zaituzte.\nSaiatu berriro beste objektu batekin";
        _eliminate.SetActive(true);

    }
    public void ReActivate()
    {
        GameObject.FindGameObjectWithTag("Soldier").SetActive(false);
        _rock.SetActive(true);
        _eliminate.SetActive(false);
        SceneLoader.Load(SceneLoader.SceneName.Game);
    }
}
