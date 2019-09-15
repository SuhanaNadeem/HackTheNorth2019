using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourManager : MonoBehaviour
{

    public GameObject paintPrefab;
    private Renderer paintRenderer;

    private float red, green, blue = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        paintRenderer = paintPrefab.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setRed(Slider slider)
    {
        red = slider.value;
        updateColours();
    }

    public void setGreen(Slider slider)
    {
        green = slider.value;
        updateColours();
    }

    public void setBlue(Slider slider)
    {
        blue = slider.value;
        updateColours();
    }

    void updateColours()
    {
        paintRenderer.material = new Material(Shader.Find("Unlit/Color"));
        paintRenderer.material.SetColor("_Color", new Color(red, green, blue, 1.0f));
    }
}
