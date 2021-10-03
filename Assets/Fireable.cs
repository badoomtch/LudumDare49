using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fireable : MonoBehaviour
{
    public GameObject cannonBall;
    private Rigidbody cannonBallRB;
    public Transform shotPosition;
    public GameObject explosion;
    public float firePower;
    public GameManager gameManager;
    public GameObject cannon;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("Manually firing cannon");
                if (gameManager.cannonBallsPickedUp >= 1)
                {   
                    gameManager.cannonBallsPickedUp -= 1;
                    cannon.GetComponent<Fireable>().FireCannon();
                    Debug.Log("Internal cannon balls " + gameManager.cannonBallsPickedUp);
                }
            }
    }

    public void FireCannon()
    {
        shotPosition.rotation = transform.rotation;
        shotPosition.position = transform.position;
        firePower *= 1;
        GameObject cannonBallCopy = Instantiate(cannonBall, shotPosition.position, shotPosition.rotation) as GameObject;
        cannonBallRB = cannonBallCopy.GetComponent<Rigidbody>();
        cannonBallRB.AddForce(transform.right * firePower);
        Instantiate(explosion, shotPosition.position, shotPosition.rotation);
    }
}
