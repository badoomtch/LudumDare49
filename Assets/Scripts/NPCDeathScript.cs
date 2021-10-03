using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDeathScript : MonoBehaviour
{
    public GameManager gameManager; 

    public void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Moveable")
        {
            Destroy(gameObject);
            gameManager.playerNPCKilled++;
        }

        if (other.tag == "Lava")
        {
            Destroy(gameObject);
            gameManager.playerNPCKilled++;
        }
    }
}
