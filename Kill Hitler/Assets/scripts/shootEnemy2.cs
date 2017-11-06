using UnityEngine;
using System.Collections;

public class shootEnemy2 : MonoBehaviour
{
    public Transform bulletEnemy;
    public float bulletDistance;
    private int timeBetweenFires;
    private float timeNextFire;
    public float poy;
    // Use this for initialization
    void Start()
    {
        timeNextFire = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenFires = Random.Range(2, 6);
        if (timeNextFire > 0)
        {
            timeNextFire -= Time.deltaTime;
        } else if (timeNextFire <= 0)
        {
            timeNextFire = timeBetweenFires;
            ShootBullet();
        }
    }
    void ShootBullet()
    {
        float posX = this.transform.position.x - bulletDistance;
        float posY = this.transform.position.y - poy;
        float posZ = -6;
        Instantiate(bulletEnemy, new Vector3(posX, posY, posZ), this.transform.rotation);
    }
}