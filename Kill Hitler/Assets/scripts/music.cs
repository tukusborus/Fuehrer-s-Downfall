using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {
    public static music Instance;

    public AudioClip shoot;
    public AudioClip destroy;
    public AudioClip enemyDestroy;
    public AudioClip bonusGun;
    public AudioClip bonusAk;
    public AudioClip bonusHH;
    public AudioClip BossKill;
    public AudioClip bossshoot;
    private void Start()
    {
        Time.timeScale = 1;
        CameraShake.Shake(0, 0);
        Cursor.visible = true;
    }

    private void Update()
    {
        int mute = PlayerPrefs.GetInt("mute");
        if (mute == -1)
        {
            AudioListener.pause = true;
        }
        else if (mute == 1)
        {
            AudioListener.pause = false;
        }
    }

    public void MakePauseOnPause()
    {
        int mute = PlayerPrefs.GetInt("mute");
        if (mute == 1)
        {
            AudioListener.volume = 0.2f;
        }
    }

    public void Continue()
    {
        int mute = PlayerPrefs.GetInt("mute");
        if (mute == 1)
        {
            AudioListener.volume = 1;
        }
    }

    private void Awake()
    {
        
        AudioListener.volume = 1;
        if (Instance != null)
        {
            Debug.LogError("2 or more examples of music!");
        }
        Instance = this;
    }

    public void FadeOut(float start, float end, float time)
    {

        AudioListener.volume = Mathf.Lerp(start, end, time * Time.deltaTime);
        Debug.Log(AudioListener.volume);
    }

    public void MakeBossShootSound()
    {
        MakeSound(bossshoot);
    }
    
    public void MakeBossDieSound()
    {
        MakeSound(BossKill);
    }

    public void MakeHHSound()
    {
        MakeSound(bonusHH);
    }

    public void MakeAkSound()
    {
        MakeSound(bonusAk);
    }

    public void MakeShotgunSound()
    {
        MakeSound(bonusGun);
    }

    public void MakeEnemyDestroy()
    {
        MakeSound(enemyDestroy);
    }

    public void MakeShootSound()
    {
        MakeSound(shoot);
    }
    public void MakeDestroySound()
    {
        MakeSound(destroy);
    }

    private void MakeSound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position, 0.5f);
    }
}
