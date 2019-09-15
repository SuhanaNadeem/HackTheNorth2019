using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;

public class PaintManager : MonoBehaviour
{
    private bool isSpraying = false;

    public GameObject paint;
    public GameObject paintCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I STARTED");
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpraying)
        {
            Debug.Log("pfffff");
            // make paint


            Vector3 location = getLocation();
            //Instantiate<GameObject>(paint, paintCanvas.transform);
            makePaint();
        }

    }

    


    public void setIsSpraying(bool yeanay)
    {
        isSpraying = yeanay;
    }

}
