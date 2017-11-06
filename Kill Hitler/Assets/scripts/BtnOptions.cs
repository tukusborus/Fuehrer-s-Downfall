using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnOptions : MonoBehaviour {

    public Transform pauseBack;
    public Button btnContinue;
    public Button pause;
    public Transform Fire;
    public Transform Joystick;
    public Button btnBack;
    public Button btnRestart;

    void Start()
    { 
        btnContinue.gameObject.SetActive(false);
        btnBack.gameObject.SetActive(false);
        btnRestart.gameObject.SetActive(false);
        pauseBack.gameObject.SetActive(false);
    }
    void Update()
    {
        
        bool pause2 = Input.GetButtonDown("pause"); //пауза по клавише неазад
        if (pause2)
        {
            if (Time.timeScale == 1)
            {
                Pause();
            }
            else if (Time.timeScale == 0)
            {
                Continue();
            }
        }
    }
    public void Back()
    {
        gameManager.ShowAd = false;
        backred.btnads = true;
        Application.LoadLevel("mainMenu");
    }

    public void Restart()
    {
        gameManager.ShowAd = false;
        backred.btnads = true;
        Application.LoadLevel("mainScene");
    }

    public void Pause()
    {
        music.Instance.MakePauseOnPause();
        Time.timeScale = 0;
        pauseBack.gameObject.SetActive(true);
        pause.gameObject.SetActive(false);
        Fire.gameObject.SetActive(false);
        Joystick.gameObject.SetActive(false);
        btnContinue.gameObject.SetActive(true);
        btnBack.gameObject.SetActive(true);
        btnRestart.gameObject.SetActive(true);

    }
    public void Continue()
    {
        music.Instance.Continue();
        pauseBack.gameObject.SetActive(false);
        pause.gameObject.SetActive(true);
        Fire.gameObject.SetActive(true);
        Joystick.gameObject.SetActive(true);
        btnContinue.gameObject.SetActive(false);
        btnBack.gameObject.SetActive(false);
        btnRestart.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
