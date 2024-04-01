using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFileBrowser;
using System.Runtime.InteropServices;

public class SaveImage : MonoBehaviour
{

    [SerializeField] private GameObject boton, boton1;
    [DllImport("__Internal")]
    private static extern void ImageDownloader(string str, string fn);

    public static byte[] ssData = null;
    public static string imageFilename = "certificate.png";
    void DownloadScreenshot()
    {
        if (ssData != null)
        {
            Debug.Log("Downloading..." + imageFilename);
            ImageDownloader(System.Convert.ToBase64String(ssData), imageFilename);
        }
    }

    public void Screenshot()
    {
        StartCoroutine(CaptureScreen());
    }

    public void OnCancel()
    {
        print("cancel");
    }
    public void OnSuccess(string[] paths)
    {
        StartCoroutine(CaptureScreen());
    }

 
    public IEnumerator CaptureScreen()
    {
        // Wait till the last possible moment before screen rendering to hide the UI
        yield return null;
        boton.SetActive(false);
        boton1.SetActive(false);

        // Wait for screen rendering to complete
        yield return new WaitForEndOfFrame();

        // Take screenshot
        Texture2D screenshoot=ScreenCapture.CaptureScreenshotAsTexture();
        print(screenshoot);
        ssData = screenshoot.EncodeToPNG();
        print(ssData);
        DownloadScreenshot();

        // Show UI after we're done
        boton.SetActive(true);
        boton1.SetActive(true);
    }
}
