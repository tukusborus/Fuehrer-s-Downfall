using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shgunSpawn : MonoBehaviour {
    float maxX = 260.0f;
    float minX = -260.0f;
    float timer;
    private float delay;
    public Transform shGun;
    int lich;

    // Use this for initialization
    void Start()
    {
        delay = 20;
        timer = delay;
        lich = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if ((gameManager.score >= Random.Range(300, 400))&&(lich == 0)){
            if (playerController.shgun < 2)
            {
                timer = timer - Time.deltaTime;
                if (timer <= 0)
                {
                    Vector3 newPos = new Vector3(Random.Range(minX, maxX), 190, -10);
                    Transform.Instantiate(shGun, newPos, transform.rotation);
                    timer = delay;
                    lich++;
                }
            }
        }

        if ((gameManager.score >= Random.Range(600, 700)) && (lich == 1))
        {
            if (playerController.shgun < 2)
            {
                timer = timer - Time.deltaTime;
                if (timer <= 0)
                {
                    Vector3 newPos = new Vector3(Random.Range(minX, maxX), 190, -10);
                    Transform.Instantiate(shGun, newPos, transform.rotation);
                    timer = delay;
                }
            }
        }
    }
}
