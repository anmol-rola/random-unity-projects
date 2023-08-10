using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed, maxVelo;
    public Rigidbody2D player;
    public float frictionalForce;
    Vector2 veloDir;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if (player.velocity.magnitude <= maxVelo) 
            {
                veloDir = new Vector2(player.transform.up.x, player.transform.up.y).normalized;
                player.velocity += speed * veloDir * Time.deltaTime;
            }
                
        }

        if (Input.GetKey("s"))
        {
            if (player.velocity.magnitude <= maxVelo)
            {
                veloDir = new Vector2(player.transform.up.x, player.transform.up.y).normalized;
                player.velocity += -speed * veloDir * Time.deltaTime;
            }
        }

        if (Input.GetKey("a"))
        {
            if (player.velocity.magnitude <= maxVelo)
            {
                veloDir = new Vector2(player.transform.right.x, player.transform.right.y).normalized;
                player.velocity += -speed * veloDir * Time.deltaTime;
            }
        }

        if (Input.GetKey("d"))
        {
            if (player.velocity.magnitude <= maxVelo)
            {
                veloDir = new Vector2(player.transform.right.x, player.transform.right.y).normalized;
                player.velocity += speed * veloDir * Time.deltaTime;
            }
        }

        else
        {
            Debug.Log(player.velocity.magnitude);
            Vector2 frictionDir = -player.velocity.normalized;
            player.velocity += frictionalForce * frictionDir * Time.deltaTime;
        }
    }
}
