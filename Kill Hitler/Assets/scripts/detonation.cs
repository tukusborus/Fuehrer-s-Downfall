using UnityEngine;
using System.Collections;

public class detonation : MonoBehaviour {
    float time = 0.5f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
