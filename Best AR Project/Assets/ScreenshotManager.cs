using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenshotManager : MonoBehaviour
{

    public GameObject panel;


    public void takeScreenshot()
    {
        panel.SetActive(false);
        ScreenCapture.CaptureScreenshot("SprayZ");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
