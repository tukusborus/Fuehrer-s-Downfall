using UnityEngine;
using System.Collections;

public class enemyBackSpawn : MonoBehaviour {
    float maxY = 139.0f;
    float minY = -90.0f;
    public float timer;
    private float delay;
    public GameObject[] obj;
    float mn = 2f;
    float mx = 4f;
    // Use this for initialization
    void Start () {
        delay = Random.Range(mn, mx);
        
    }
	
	// Update is called once per frame
	void Update () {
            timer = timer - Time.deltaTime;
            if (timer <= 0 && gameManager.score <= 50)
            {
                int objN = Random.Range(0, 1);
                Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), 49);
                Transform.Instantiate(obj[objN], newPos, transform.rotation);
                timer = delay;
            }
            else if (timer <= 0 && gameManager.score <= 150)
            {
                int objN = Random.Range(0, 2);
                Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), 49);
                Transform.Instantiate(obj[objN], newPos, transform.rotation);
                timer = delay;
            }
            else if (timer <= 0 && gameManager.score <= 350)
            {
                int objN = Random.Range(0, 3);
                Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), 49);
                Transform.Instantiate(obj[objN], newPos, transform.rotation);
                timer = delay;
            }
            else if (timer <= 0 && gameManager.score <= 650)
            {
                int objN = Random.Range(0, 4);
                Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), 49);
                Transform.Instantiate(obj[objN], newPos, transform.rotation);
                timer = delay;
            }
            else if (timer <= 0 && gameManager.score <= 1000)
            {
                int objN = Random.Range(0, 5);
                Vector3 newPos = new Vector3(transform.position.x, Random.Range(minY, maxY), 49);
                Transform.Instantiate(obj[objN], newPos, transform.rotation);
                timer = delay;
            }
        }
    }

