using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public GameObject cannonBallExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Moveable")
        {
            //Debug.Log("Hit by cannon");
            Destroy(gameObject);
            Instantiate(cannonBallExplosion, transform.position, transform.rotation);
        }
    }
}
