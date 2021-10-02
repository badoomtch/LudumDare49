using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraatStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float wait = 1f;
    private void Awake()
    {
        StartCoroutine("LookForwardAtStart");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LookForwardAtStart()
    {
        player.GetComponent<FirstPersonAIO>().enabled = false;
        yield return new WaitForSeconds(wait);
        player.GetComponent<FirstPersonAIO>().enabled = true;
        StopCoroutine("LookForwardAtStart");
    }
}
