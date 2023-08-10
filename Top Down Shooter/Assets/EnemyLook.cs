using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    public Transform enemy;
    public Transform player;
    public float enemySpeed, minDist;

    // Update is called once per frame
    void Update()
    {
        enemy.rotation = Quaternion.LookRotation(Vector3.forward, player.position - enemy.position);
        Vector3 distance = player.position - enemy.position;
        if (distance.magnitude >= minDist)
        {
            enemy.position += distance.normalized * enemySpeed * Time.deltaTime;
        }
    }
}
