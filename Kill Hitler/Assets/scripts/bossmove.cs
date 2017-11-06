using UnityEngine;
using System.Collections;

public class bossmove : MonoBehaviour
{
    public Transform detonation;
    public float hp;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;       
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "bullet")
        {           
            hp = hp - 1;
            CameraShake.Shake(1, 1);
 
        }
        if (hp == 0)
        {
            Destroy(this.gameObject);
            Time.timeScale = 0.5f;
            Detonation();
            Detonation1();
            Detonation3();
            Detonation4();
            Detonation5();
            Detonation6();
        }
    }
    void Detonation()
    {
        music.Instance.MakeBossDieSound();
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
    void Detonation1()
    {
        float posX = this.transform.position.x+80;
        float posY = this.transform.position.y+10;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
    void Detonation2()
    {
        float posX = this.transform.position.x - 50;
        float posY = this.transform.position.y - 30;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
    void Detonation3()
    {
        float posX = this.transform.position.x +20;
        float posY = this.transform.position.y - 60;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
    void Detonation4()
    {
        float posX = this.transform.position.x - 65;
        float posY = this.transform.position.y + 50;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
    void Detonation5()
    {
        float posX = this.transform.position.x - 50;
        float posY = this.transform.position.y - 80;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
    void Detonation6()
    {
        float posX = this.transform.position.x + 70;
        float posY = this.transform.position.y + 66;
        float posZ = this.transform.position.z;
        Instantiate(detonation, new Vector3(posX, posY, posZ), this.transform.rotation);

    }
}