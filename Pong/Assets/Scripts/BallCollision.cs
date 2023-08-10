
using UnityEngine;


public class BallCollision : MonoBehaviour
{
    public Rigidbody ball;
    public float increment = 5f;
    

    
   void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.name == "Player1")
        {
            Vector3 velo = ball.velocity;
            velo.x = collisionInfo.relativeVelocity.x - increment;
            velo.y = -collisionInfo.relativeVelocity.y;
            ball.velocity = velo;
            FindObjectOfType<AudioManager>().Play("BallCollision");
        }

        if (collisionInfo.collider.name == "Player2")
        {
            Vector3 velo = ball.velocity;
            velo.x = collisionInfo.relativeVelocity.x + increment;
            velo.y = -collisionInfo.relativeVelocity.y;
            ball.velocity = velo;
            FindObjectOfType<AudioManager>().Play("BallCollision");
        }

        if (collisionInfo.collider.tag == "Boundary")
        {
            Vector3 velo = ball.velocity;
            velo.y = collisionInfo.relativeVelocity.y;
            velo.x = -collisionInfo.relativeVelocity.x;
            ball.velocity = velo;
            FindObjectOfType<AudioManager>().Play("BallCollision");
        }
    } 
    
}
