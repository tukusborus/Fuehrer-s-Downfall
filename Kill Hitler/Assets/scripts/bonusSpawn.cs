using UnityEngine;
using System.Collections;

public class bonusSpawn : MonoBehaviour
{

    float maxX = 260.0f;
    float minX = -260.0f;
    float timer;
    private float delay;
    public GameObject[] obj;

    float mn = 10;
    float mx = 30;



    // Use this for initialization
    void Start()
    {
        delay = Random.Range(mn, mx);
        timer = delay;

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            int objN = Random.Range(0, 3);
            Vector3 newPos = new Vector3(Random.Range(minX, maxX), 190, -10);
            Transform.Instantiate(obj[objN], newPos, transform.rotation);
            timer = delay;
        }
    }
}
