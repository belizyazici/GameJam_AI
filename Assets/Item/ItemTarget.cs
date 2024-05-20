using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTarget : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    { 
        renderer.material.color = Color.red;   
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }

}

