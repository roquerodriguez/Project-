using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI, GameOverUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        GameOverUI.SetActive(false);
    }
   

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void LoadMain()
    {
        
        SceneManager.LoadScene("Alien_vs_Balloon_Roque_Rodriguez");
        Time.timeScale = 1f;
        Scoring.scorevalue = 0;

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
