
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score_p1 = 0, score_p2 = 0;
    public GameObject ball, respawnPoint, player1_spawn, player2_spawn, player1, player2;
    public Rigidbody rb_ball, rb_p1, rb_p2;

    public void EndMatch()
    {
        Debug.Log("GameOver!!");
        Invoke("RestartGame", 2f);
        
    }
    public void EndRound()
    {
        Debug.Log("NEXTROUND!!");
        Invoke("RespawnBall", 1f);
    }

    public void RespawnBall()
    {
        ball.transform.position = respawnPoint.transform.position;
        player1.transform.position = player1_spawn.transform.position;
        player2.transform.position = player2_spawn.transform.position;
        Vector3 restart_velo = Vector3.zero;
        rb_ball.velocity = restart_velo;
        rb_p1.velocity = restart_velo;
        rb_p1.velocity = restart_velo;
        FindObjectOfType<BallMovement>().PlayerScored = false;
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene("MainMenu");
        FindObjectOfType<BallMovement>().PlayerScored = true;
    }

}
