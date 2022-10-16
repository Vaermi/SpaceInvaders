using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", interval, interval);
    }

    void ShootBullet()
    {
        if (bullet != null)
        {
            GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);

        }
    }
}
