using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneRechargue : MonoBehaviour
{
    public void Rechargue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
