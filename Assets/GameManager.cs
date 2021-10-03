using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float EnemyNPCKilled;
    public float playerNPCKilled;
    public float cannonBallsPickedUp;
    
    public TextMeshProUGUI enemyNPCKilledText;
    public TextMeshProUGUI playerNPCKilledText;
    public TextMeshProUGUI cannonBallsPickedUpText;

    public TextMeshProUGUI popUpText;

    public GameObject pauseMenu;
    public GameObject player;

    public string tipTextString;

    // Start is called before the first frame update
    void Start()
    {
        if (pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (pauseMenu.activeSelf)
            {
                ResumeGame();
                player.GetComponent<FirstPersonAIO>().ControllerPause();
            }
            else
            {
                PauseGame();
            }
        }

        enemyNPCKilledText.text = "Enemy Citizens Left: " + (10f - EnemyNPCKilled).ToString();
        playerNPCKilledText.text = "Your Citizens Left: " + (10f - playerNPCKilled).ToString();
        cannonBallsPickedUpText.text = "Cannon Balls: " + cannonBallsPickedUp + "/ 15";
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        player.GetComponent<FirstPersonAIO>().ControllerPause();
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
