using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Breakable")
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Destroy(gameObject, 20f);
    }
}
