using UnityEngine;
using System.Collections;

public class hitlerRagedestroy : MonoBehaviour {
    public float time = 3f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
