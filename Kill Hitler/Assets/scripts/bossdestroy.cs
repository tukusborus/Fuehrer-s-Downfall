using UnityEngine;
using System.Collections;

public class bossdestroy : MonoBehaviour {
    public Mover boss;
    public float time;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (boss == null)
        {
            CameraShake.Shake(5, 2);
            music.Instance.FadeOut(1, 0, 50);
            Fadeout.sceneEnd2 = true;          
        }

    }
}
