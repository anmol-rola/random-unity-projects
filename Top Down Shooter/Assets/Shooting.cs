using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform leftBarrel, rightBarrel;
    public GameObject bullet;
    public float bulletVelo;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Shoot();
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
