using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Breakable")
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Destroy(gameObject, 20f);
    }
}
