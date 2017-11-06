using UnityEngine;
using System.Collections;

public class ak47 : MonoBehaviour
{
    public float pos;
    float speed = 30;

    void Update()
    {
        if (transform.position.y < pos)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.down * Time.deltaTime * speed);

    }
}
