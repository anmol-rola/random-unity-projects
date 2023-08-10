using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform transform_ball;
    public Rigidbody rb_ball;
    public float init_force;
    public int ScoreIncreased = 0;
    public bool PlayerScored = false;
    public GameObject Onwin_location, Winner_location, MainMenu_location, button;
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb_ball.velocity.magnitude == 0)
        {
            if (ScoreIncreased == 0) //start of the round
            {
                rb_ball.AddForce(init_force, 0, 0, ForceMode.Impulse);
            }


            if (ScoreIncreased != 0) //when round resets
            {
                rb_ball.AddForce(ScoreIncreased * init_force, 0, 0, ForceMode.Impulse);
            }
        }


        //Player2 wins
        else if (transform_ball.position.x > 17)
        {
            if (!PlayerScored)
            {
                FindObjectOfType<GameManager>().score_p2++;
                ScoreIncreased = -1;
                

                if (FindObjectOfType<GameManager>().score_p2 == 10)
                {
                    button.transform.position = MainMenu_location.transform.position;
                    FindObjectOfType<TextScript>().winner.text = 2.ToString();
                    FindObjectOfType<TextScript>().winner.transform.position = Winner_location.transform.position;
                    FindObjectOfType<TextScript>().onwin.transform.position = Onwin_location.transform.position;
                    FindObjectOfType<AudioManager>().Play("OnWin");
                    PlayerScored = true;
                }
                else
                {
                    PlayerScored = true;
                    FindObjectOfType<GameManager>().EndRound();
                }
            }
            
        }

        //Player1 wins
        else if (transform_ball.position.x < -17)
        {
            if (!PlayerScored)
            {
                FindObjectOfType<GameManager>().score_p1++;
                ScoreIncreased = 1;
                

                if (FindObjectOfType<GameManager>().score_p1 == 10)
                {
                    button.transform.position = MainMenu_location.transform.position;
                    FindObjectOfType<TextScript>().winner.text = 1.ToString();
                    FindObjectOfType<TextScript>().winner.transform.position = Winner_location.transform.position;
                    FindObjectOfType<TextScript>().onwin.transform.position = Onwin_location.transform.position;
                    FindObjectOfType<AudioManager>().Play("OnWin");
                    PlayerScored = true;
                }
                else
                {
                    PlayerScored = true;
                    FindObjectOfType<GameManager>().EndRound();    
                }
            }
            
        }

    }

    void PrintVelo()
    {
        print(rb_ball.velocity);
    }
}
