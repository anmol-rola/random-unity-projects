using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    public Rigidbody rb_player_1;
    public Rigidbody rb_player_2;
    public float force;
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb_player_1.AddForce(0, force * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (Input.GetKey("s"))
        {
            rb_player_1.AddForce(0, -force * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb_player_2.AddForce(0, force * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb_player_2.AddForce(0, -force * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
}
