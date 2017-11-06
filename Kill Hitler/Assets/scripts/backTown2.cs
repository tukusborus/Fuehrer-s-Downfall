using UnityEngine;
using System.Collections;

public class backTown2 : MonoBehaviour {
    public float timer2 = 11f;
    public float delay2 = 22f;
   
    public Transform town2;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer2 = timer2 - Time.deltaTime;
        if (timer2 <= 0)
        {

            Instantiate(town2, new Vector3(800, 0, 48), this.transform.rotation);
            timer2 = delay2;
        }
    }
}
