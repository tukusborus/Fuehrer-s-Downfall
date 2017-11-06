using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour
{
    public float speed;
    public int health;
    gameManager gm;
    GameObject obj;
    public Transform detonation;
    public int addscore;    

    // Use this for initialization
    void Start()
    {
        obj = GameObject.Find("gameManager");
        gm = (gameManager)obj.GetComponent(typeof(gameManager));
    }
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            Detonation();
        }

        if (coll.gameObject.tag == "portal")
        {
            Destroy(this.gameObject);
            Detonation();
        }

        if (coll.gameObject.tag == "bullet2")
        {
            Destroy(this.gameObject);
            gm.addScore(1);
            Detonation();
        }
        if (coll.gameObject.tag == "bullet")
        {
            health = health - 1 ;
            Destroy(coll.gameObject);
            Detonation();
        }
       
        if (health <= 0)
        {
            Destroy(this.gameObject);
            gm.addScore(addscore);
        }
    }
    void Detonation()
    {
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);
        music.Instance.MakeEnemyDestroy();
    }

}