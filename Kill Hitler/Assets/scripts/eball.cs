using UnityEngine;
using System.Collections;

public class eball : MonoBehaviour
{
    public Transform elball;
    public float timeStart;
    public float timeBetweenFires;
    private float timeTilNextFire = 0.0f;

    void Start()
    {
        timeTilNextFire = timeStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeTilNextFire > 0)
        {
            timeTilNextFire -= Time.deltaTime;
        }
        if (timeTilNextFire <= 0)
        {
            timeTilNextFire = timeBetweenFires;
            Shootball();
        }

    }
    public void Shootball()
    {
        float posX = this.transform.position.x  ;
        float posY = this.transform.position.y  ;
        music.Instance.MakeBossShootSound();
        Instantiate(elball, new Vector3(posX, posY, 0), this.transform.rotation);
    }
}

