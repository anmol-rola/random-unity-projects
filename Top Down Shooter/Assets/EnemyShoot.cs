using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform leftBarrel, rightBarrel,player;
    public GameObject bullet;
    public float bulletVelo, range;
    float timePassed = 0;
    public float minTimeGap;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        float distance = (player.position - transform.position).magnitude;
        if (timePassed >= minTimeGap && distance <= range)
        {
            Shoot();
            timePassed = 0;
        }
    }

    public void Shoot()
    {
        if (bullet != null)
        {
            GameObject bulletRight = Instantiate(bullet, rightBarrel);
            GameObject bulletLeft = Instantiate(bullet, leftBarrel);

            bulletLeft.transform.parent = null;
            bulletRight.transform.parent = null;

            Rigidbody2D rbLeft = bulletLeft.GetComponent<Rigidbody2D>();
            Rigidbody2D rbRight = bulletRight.GetComponent<Rigidbody2D>();

            rbLeft.velocity = bulletVelo * leftBarrel.up;
            rbRight.velocity = bulletVelo * rightBarrel.up;
        }

        else Debug.Log("NoBullet :(");
    }
}
