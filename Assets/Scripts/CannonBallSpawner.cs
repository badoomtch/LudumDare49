using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawner : MonoBehaviour
{
    public GameObject cannonBallSpawner;

    Vector3 originPosition;
    Vector3 movedPosition;
    // Start is called before the first frame update
    void Start()
    {
        originPosition = gameObject.transform.position;
        movedPosition = gameObject.transform.position + new Vector3(0,-100f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCannonBallsCo()
    {
        cannonBallSpawner.transform.position = movedPosition;
        yield return new WaitForSeconds(60f);
        cannonBallSpawner.transform.position = originPosition;
    }

    public void grabCannonBalls()
    {
        StartCoroutine("SpawnCannonBallsCo");
    }
}
