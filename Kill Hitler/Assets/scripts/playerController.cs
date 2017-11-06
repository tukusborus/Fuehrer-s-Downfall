using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using CnControls;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public float playerSpeed;
    private Animator anim;
    public Transform bullet;
    public Transform shotgun;
    public Transform support;
    public float bulletDistance;
    public float timeBetweenFires;
    private float timeNextFire = 0.0f;
    public Transform detonation;
    public gameManager gm;
    public static int shgun;
    public Image hit;
    float timeHit;

    void Start()
    {
        hit.gameObject.SetActive(true);
        shgun = 0;
        anim = this.GetComponent<Animator>();
    }
   
    void Update()
    {
        float transV = Mathf.Clamp(transform.position.y + CnInputManager.GetAxis("Vertical") * playerSpeed * Time.deltaTime, -142, 142);    //управление джойстик
        float transH = Mathf.Clamp(transform.position.x + CnInputManager.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, -239, 239);

        transform.position = (new Vector3(transH, transV, -5));

        if (CnInputManager.GetAxis("Vertical") > 0)
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
            anim.SetBool("main", false);
        }

        if (CnInputManager.GetAxis("Vertical") < 0)
        {
            anim.SetBool("left", false);
            anim.SetBool("right", true);
            anim.SetBool("main", false);
        }
        if (CnInputManager.GetAxis("Vertical") == 0)
        {
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("main", true);
        }
//******************************************************************       
        bool shoot = CnInputManager.GetButtonDown("Jump");  //выстрел
        bool shoot2 = Input.GetButtonDown("Fire1");
                if(timeNextFire > 0)
        {
            timeNextFire -= Time.deltaTime;
        } else if ((shoot && timeNextFire <= 0)||(shoot2 && timeNextFire <= 0))
        {
            timeNextFire = timeBetweenFires;
            ShootBullet();
        }
        //******************************************************************

        if (timeHit > 0)
        {
            timeHit -= Time.deltaTime;
        } else if (timeHit <= 0)
        {
            hit.gameObject.SetActive(false);
        }

    }

    void ShootBullet()
    {
        music.Instance.MakeShootSound();
        float posX = this.transform.position.x + bulletDistance;
        float posY = this.transform.position.y;
        Instantiate(bullet, new Vector3(posX, posY, 0), this.transform.rotation);
        if(shgun == 1)
        {
            Instantiate(bullet, new Vector3(posX + 50, posY, 0), this.transform.rotation);
        }
        else if (shgun >= 2)
        {
            Instantiate(shotgun, new Vector3(posX + 65, posY+10, 0), this.transform.rotation);
        }
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
            Detonation();

        }
        if (coll.gameObject.tag == "hitle")
        {
            Destroy(coll.gameObject);
            gameManager.score = 0;
            hit.gameObject.SetActive(true);
            timeHit = 0.5f;
            music.Instance.MakeHHSound();
        }
       
        if (coll.gameObject.tag == "ak")
        {
           
            Destroy(coll.gameObject);
            Instantiate(support, new Vector3(65, -12, -4), this.transform.rotation);
            CameraShake.Shake(3, 2);
            music.Instance.MakeAkSound();
        }

        if (coll.gameObject.tag == "shotgun")
        {
            shgun++;
            Destroy(coll.gameObject);
            music.Instance.MakeShotgunSound();
        }

        if (coll.gameObject.tag == "enemyBullet")
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            Detonation();
        }
        if (coll.gameObject.tag == "enemy")
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            Detonation();
        }

        if (coll.gameObject.tag == "portal2")
        {
            music.Instance.FadeOut(1, 0, 30);
            Fadeout.sceneEnd2 = true;
        }

    }

    void Detonation()
    {
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);
        music.Instance.MakeDestroySound();
    }
}


