using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(-10, -10, 10);        // modified position
        transform.localScale = Vector3.one * 3.0f;     // modified size (Vector3.one is shorthand for writing Vector3(1,1,1))
        
        Material material = Renderer.material;
        
        material.color = new Color(0, 1, 1, 1);     // modified color
    }
    
    void Update()
    {
        transform.Rotate(100.0f * Time.deltaTime, -500.0f * Time.deltaTime, 75.0f * Time.deltaTime);       // modified rotation and speed
    }
}
