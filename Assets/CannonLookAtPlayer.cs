 using UnityEngine;
 
 public class CannonLookAtPlayer: MonoBehaviour
 {
     //values that will be set in the Inspector
     public Transform Target;
 
    void Start()
    {
        
    }
 
    void LateUpdate()
    {
        transform.LookAt(Target);
        transform.rotation *= Quaternion.FromToRotation(Vector3.left, Vector3.back);
    }
 }