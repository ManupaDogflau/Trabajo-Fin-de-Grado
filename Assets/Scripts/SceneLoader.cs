using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void Load(SceneName scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public enum SceneName
    {
        MainMenu,
        Game,
        End
    }
}
