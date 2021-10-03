using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float EnemyNPCKilled;
    public float playerNPCKilled;
    public float cannonBallsPickedUp = 0;
    
    public TextMeshProUGUI enemyNPCKilledText;
    public TextMeshProUGUI playerNPCKilledText;
    public TextMeshProUGUI cannonBallsPickedUpText;

    public TextMeshProUGUI popUpText;

    public GameObject pauseMenu;
    public GameObject player;

    public string tipTextString;

    public GameObject loseWindow;
    public GameObject winWindow;

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

        enemyNPCKilledText.text =  (10f - EnemyNPCKilled).ToString() + "/10";
        playerNPCKilledText.text = (10f - playerNPCKilled).ToString() + "/10";
        cannonBallsPickedUpText.text = cannonBallsPickedUp + "/ 15";
        
        if (EnemyNPCKilled <= 0)
        {
            //win
        }
        if (playerNPCKilled <= 0)
        {
            //win
        }
    }

    public void WinGame()
    {
        player.GetComponent<FirstPersonAIO>().ControllerPause();
        winWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoseGame()
    {
        player.GetComponent<FirstPersonAIO>().ControllerPause();
        loseWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        player.GetComponent<FirstPersonAIO>().ControllerPause();
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("Castles");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
