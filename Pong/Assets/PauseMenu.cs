using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        Invoke("LoadScene", 0.3f);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        Invoke("Quit", 0.3f);
        Time.timeScale = 1f;
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Quit()
    {
        Application.Quit();
    }
}
