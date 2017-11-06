using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {
    public float speed;
    public Transform detonation;
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
	}
    void OnTriggerEnter2D(Collider2D coll)

    {
        if (coll.gameObject.tag == "boss")
        {
            Destroy(this.gameObject);
            Detonation();
            
        }
        if (coll.gameObject.tag == "eball")
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject); 
        }
    }
    void Detonation()
    {
        music.Instance.MakeEnemyDestroy();
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
}
