using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannonController : MonoBehaviour
{
    public GameObject cannonBall;
    private Rigidbody cannonBallRB;
    public Transform shotPosition;
    public GameObject explosion;
    public float firePower;

    void Start()
    {
        StartCoroutine(FireEnemyCannonCo());
    }

    public void FireEnemyCannon()
    {
        shotPosition.rotation = transform.rotation;
        shotPosition.position = transform.position;
        firePower *= 1;
        GameObject cannonBallCopy = Instantiate(cannonBall, shotPosition.position, shotPosition.rotation) as GameObject;
        cannonBallRB = cannonBallCopy.GetComponent<Rigidbody>();
        cannonBallRB.AddForce(transform.right * firePower);
        Instantiate(explosion, shotPosition.position, shotPosition.rotation);
    }

     IEnumerator FireEnemyCannonCo()
    {
        float randomNumber = Random.Range(5f,8f);
        yield return new WaitForSeconds(randomNumber);
        FireEnemyCannon();
        StartCoroutine(FireEnemyCannonCo());
    }
}
