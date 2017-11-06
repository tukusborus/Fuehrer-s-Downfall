using UnityEngine;
using System.Collections;

public class controllball : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start () {
        Destroy(gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Vector3.left) * Time.deltaTime * speed);
    }
}
