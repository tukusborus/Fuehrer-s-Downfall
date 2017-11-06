using UnityEngine;
using System.Collections;

public class town : MonoBehaviour {
    public float speed;
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
