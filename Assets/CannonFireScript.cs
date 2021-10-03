using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFireScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject cannon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ReliableOnTriggerExit.NotifyTriggerEnter(other, gameObject, OnTriggerExit);
            cannon.GetComponent<Fireable>().enabled = true;
            Debug.Log("OnTriggerEnter");
        }

    }

    private void OnTriggerExit(Collider other)
    {   
        if (other.tag == "Player")
        {
        ReliableOnTriggerExit.NotifyTriggerExit(other, gameObject);
        cannon.GetComponent<Fireable>().enabled = false;
        Debug.Log("OnTriggerExit");
        }
    }
}
