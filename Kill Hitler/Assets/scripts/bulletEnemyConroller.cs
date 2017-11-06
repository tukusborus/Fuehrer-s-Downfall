using UnityEngine;
using System.Collections;

public class bulletEnemyConroller : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    void Start()
       
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "portal")
        {
            Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "bullet2")
        {
           
            Destroy(this.gameObject);
          
        }
        if (coll.gameObject.tag == "bullet")
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
    }
}