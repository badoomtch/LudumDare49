using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallPickup : MonoBehaviour
{
    public float interactionDistance = 20f;

    public GameManager gameManager;
    public Camera camera;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * interactionDistance);

        RaycastHit hitInfo = new RaycastHit();
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        bool cannonHit = Physics.Raycast(ray, out hitInfo, interactionDistance);
        if (cannonHit)
        {
            if (hitInfo.transform.CompareTag("Cannon5") )
            {
                if (5 + gameManager.cannonBallsPickedUp <= 15 && Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Picking up 5 cannon balls");
                    gameManager.cannonBallsPickedUp +=5f;
                    hitInfo.transform.GetComponent<CannonBallSpawner>().grabCannonBalls();
                }
            }

            if (hitInfo.transform.CompareTag("Cannon10"))
            {
                if (10 + gameManager.cannonBallsPickedUp <= 15 && Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Picking up 10 cannon balls");
                    gameManager.cannonBallsPickedUp +=10f;
                    hitInfo.transform.GetComponent<CannonBallSpawner>().grabCannonBalls();
                }
            }
        }
        
    }
}
