using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treescript : MonoBehaviour
{
    /*
      * The wanted length for the Raycast.
      */
     public float distance = 100f;

     void Update() 
     {
         /*
          * Create the hit object.
          */
         RaycastHit hit;
         /*
          * Cast a Raycast.
          * If it hits something:
          */
         if(Physics.Raycast(transform.position, Vector3.down, out hit, distance)) {
             /*
              * Set the target location to the location of the hit.
              */
             Vector3 targetLocation = hit.point;
             /*
              * Modify the target location so that the object is being perfectly aligned with the ground (if it's flat).
              */
             targetLocation += new Vector3(0, 4f, 0);
             /*
              * Move the object to the target location.
              */
             transform.position = targetLocation;
         }
     }
}

