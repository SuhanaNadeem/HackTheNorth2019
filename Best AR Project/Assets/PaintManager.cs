using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
//using UnityEngine.Experimental.XR;

public class PaintManager : MonoBehaviour
{
    private bool isSpraying = false;

    public GameObject paint;
    public GameObject paintCanvas;

    //private ARSessionOrigin arSessionOrigin;
    private ARRaycastManager arRaycastManager;
    private Pose placementPose;
    private bool placementPoseIsValid = false;
    
    // Start is called before the first frame update
    void Start()
    {
        arRaycastManager = FindObjectOfType<ARSessionOrigin>().GetComponent<ARRaycastManager>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isSpraying)
        {
            PaintTarget();
        }

    }

    void PaintTarget()
    {
        Vector3 screenCentre = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        List<ARRaycastHit> rayHits = new List<ARRaycastHit>();
        arRaycastManager.Raycast(screenCentre, rayHits, TrackableType.Planes);

        placementPoseIsValid = rayHits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose = rayHits[0].pose;

            GameObject newPaint = Instantiate<GameObject>(paint, placementPose.position, placementPose.rotation, paintCanvas.transform);

        }
        
    }
    

    public void setIsSpraying(bool yeanay)
    {
        isSpraying = yeanay;
    }

}
