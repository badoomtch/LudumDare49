using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private bool isZoomed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Zoom"))
        {
            if (!isZoomed)
            {
                gameObject.GetComponent<Camera>().fieldOfView = gameObject.GetComponent<Camera>().fieldOfView * 0.4f;
            }
        }
        if (Input.GetButtonUp("Zoom"))
        {
            gameObject.GetComponent<Camera>().fieldOfView = 70f;
        }
    }
}
