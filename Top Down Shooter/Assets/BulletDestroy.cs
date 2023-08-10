using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float bulletTime;
    void Update()
    {
        Destroy(this.gameObject, bulletTime);
    }

    void OnCollisionEnter(Collision colliderInfo)
    {
        if(colliderInfo.collider.tag == "Enemy")
        {
            //Apply damage to enemy
            //some effect
            //destroy bullet
        }
    }
}
