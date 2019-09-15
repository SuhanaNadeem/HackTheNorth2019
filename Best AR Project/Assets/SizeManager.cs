using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeManager : MonoBehaviour
{
    public GameObject paintPrefab;
    public GameObject crosshair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void setSize(Slider slider)
    {
        float size = slider.value;
        paintPrefab.transform.localScale = new Vector3(size, paintPrefab.transform.localScale.y, size);
        crosshair.transform.localScale = new Vector3(size, crosshair.transform.localScale.y, size);
    }
}
