using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    //public GameObject particles;
    
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D colliderInfo)
    {
        if(colliderInfo.collider.tag == "Enemy")
        {
            //ApplyDamage();
            //SomeEffect
        }

        else if(colliderInfo.collider.tag == "Player")
        {
            //Damage();
            //SomeEffect
        }

        else
        {
            Transform particleSpawn = this.transform;
            Destroy(this.gameObject);
            //GameObject effect = Instantiate(particles, particleSpawn.position, Quaternion.identity);
            //Destroy(effect, 0.2f);
        }
    }
}
