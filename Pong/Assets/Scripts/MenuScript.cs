using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("OnClick");
        Invoke("LoadScene", 0.3f);     
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("OnClick");
        Invoke("Quit", 0.3f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Level01");
    }

    void Quit()
    {
        Application.Quit();
    }
}
