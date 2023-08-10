using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI score_2, score_1, winner, onwin;

    // Update is called once per frame
    void Update()
    {
        score_1.text = FindObjectOfType<GameManager>().score_p1.ToString();
        score_2.text = FindObjectOfType<GameManager>().score_p2.ToString();
    }

    public void LoadMainMenu()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        Invoke("LoadScene", 0.3f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
