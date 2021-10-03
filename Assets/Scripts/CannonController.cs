using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public int speed;
    public float friction;
    public float lerpSpeed;
    float xDegrees;
    float yDegrees;
    Quaternion fromRotation;
    Quaternion toRotation;
    public Camera camera;
    public float interactionDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo = new RaycastHit();
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        bool hitCannon = Physics.Raycast(ray, out hitInfo, interactionDistance);
        
        if (hitCannon)
        {
            if (hitInfo.transform.CompareTag("Cannon"))
            {
                if (Input.GetMouseButton(0))
                {
                    xDegrees -= Input.GetAxis("Mouse Y") * speed * friction;
                    yDegrees -= Input.GetAxis("Mouse X") * speed * friction;
                    fromRotation = transform.rotation;
                    toRotation = Quaternion.Euler(0, yDegrees , xDegrees);
                    transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * lerpSpeed);
                }
            }
        }

        
    }

    
}
