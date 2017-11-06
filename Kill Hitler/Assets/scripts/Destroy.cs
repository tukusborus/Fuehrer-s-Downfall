using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public GameObject player;
    void Update () {
        player = GameObject.Find("player");
		if (player == null)
        {
                CameraShake.Shake(2, 1);
                Time.timeScale = 0.5f;
                Invoke("TimeScale", 0.5f);
                Fadeout.sceneEnd = true;
                music.Instance.FadeOut(1, 0, 50);
        }
	}
    void TimeScale()
    {
        Time.timeScale = Mathf.Lerp(0.5f, 1, 50 * Time.deltaTime);
    }
}
