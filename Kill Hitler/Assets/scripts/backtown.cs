using UnityEngine;
using System.Collections;

public class backtown : MonoBehaviour {
    public float timer = 11f;
    public float delay = 22f;
  
    public Transform town;
   
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
      
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {

            Instantiate(town, new Vector3(800, 0, 47), this.transform.rotation);
            timer = delay;
        }
       
    }
}
