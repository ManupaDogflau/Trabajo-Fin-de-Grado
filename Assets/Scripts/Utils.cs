using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    public static void OpenURL(string url)
    {
        Application.OpenURL(Uri.EscapeUriString(url));
    }
}
