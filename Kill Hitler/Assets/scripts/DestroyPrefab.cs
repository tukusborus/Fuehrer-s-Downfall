using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour {
    public float pos;
    public float pos2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if((transform.position.x < pos)||(transform.position.x > pos2))
        {
            Destroy(this.gameObject);
        }		
	}
}
