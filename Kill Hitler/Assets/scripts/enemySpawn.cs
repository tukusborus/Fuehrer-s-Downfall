using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour
{

    float maxY = 139.0f;
    float minY = -135.0f;
    public float timer;
    private float delay;
    public GameObject[] obj;
    float mn = 1;
    float mx = 1.5f;
    public Transform portal;
    public Transform portal2;
    bool make;
    
    // Use this for initialization
    private void Start()
    {
        make = true;
    }
    // Update is called once per frame
    void Update()
    {
        delay = Random.Range(mn, mx);

        timer = timer - Time.deltaTime;
        if (timer <= 0 && gameManager.score <= 50)
        {
            int objN = Random.Range(0, 1);
            Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
            Transform.Instantiate(obj[objN], newPos, transform.rotation);
            timer = delay;

        }
        else if (timer <= 0 && gameManager.score <= 150)
        {
            int objN = Random.Range(0, 2);
            Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
            Transform.Instantiate(obj[objN], newPos, transform.rotation);
            timer = delay;
        }
        else if (timer <= 0 && gameManager.score <= 350)
        {
            int objN = Random.Range(0, 3);
            Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
            Transform.Instantiate(obj[objN], newPos, transform.rotation);
            timer = delay;
        }
        else if (timer <= 0 && gameManager.score <= 650)
        {
            int objN = Random.Range(0, 4);
            Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
            Transform.Instantiate(obj[objN], newPos, transform.rotation);
            timer = delay;
        }
        else if (timer <= 0 && gameManager.score <= 1000)
        {
            int objN = Random.Range(0, 5);
            Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
            Transform.Instantiate(obj[objN], newPos, transform.rotation);
            timer = delay;
        }

        if ((gameManager.score >= 1000) && (make))
        {
            make = false;
            Instantiate(portal, new Vector3(0, 0, 0), transform.rotation);
            Instantiate(portal2, new Vector3(200, 0, 0), transform.rotation);
        }
    }
}
