using UnityEngine;
using System.Collections;

public class showhitle : MonoBehaviour {
    public Transform hitlerrage;
    float timeRage;
    float betwtimeRage;

    // Use this for initialization
    void Start () {
        betwtimeRage = Random.Range(90, 180);
        timeRage = betwtimeRage;
    }
	
	// Update is called once per frame
	void Update () {
        timeRage = timeRage - Time.deltaTime;
        if (timeRage <= 0)
        {
            Instantiate(hitlerrage, new Vector3(0,-172), this.transform.rotation);
            timeRage = betwtimeRage;
        }
    }
}
