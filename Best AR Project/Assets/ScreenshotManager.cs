using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenshotManager : MonoBehaviour
{

    public GameObject panel;
    private float counter = 0;


    public void takeScreenshot()
    {
        panel.SetActive(false);
        ScreenCapture.CaptureScreenshot("SprayZ.png");
        counter = 0.5f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0)
        {
            counter += -Time.deltaTime;
        }
        else if (-1.0f < counter && counter <= 0f)
        {
            panel.SetActive(true);
            counter = -2.0f;
        }
    }
}
