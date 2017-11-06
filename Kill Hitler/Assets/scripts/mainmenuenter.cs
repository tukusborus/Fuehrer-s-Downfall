using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainmenuenter : MonoBehaviour
{
    public Button btnSound;
    public bool CanMute;
    int muteBTN;
    private void Update()
    {
        muteBTN = PlayerPrefs.GetInt("mute");
        if(muteBTN == -1)
        {
            CanMute = false;
            btnSound.gameObject.SetActive(false);
        } else if (muteBTN == 1)
        {
            CanMute = true;
            btnSound.gameObject.SetActive(true);
        }
    }
    public void ChangeScene()
    {
        music.Instance.FadeOut(1, 0, 100);
        gameManager.ShowAd = false;
        backred.btnads = true;
        FadeInOut.sceneEnd = true;
    }

    public void Info()
    {
        music.Instance.FadeOut(1, 0, 100);
        Fadeout.sceneEnd = true;
    }


    public void Rate()
    {
        Application.OpenURL("http://vk.com/tukus_borus");
    }

    public void Mute()
    {
        if (CanMute)
        {
            PlayerPrefs.SetInt("mute", -1);
        } else if(!CanMute)
        {
            PlayerPrefs.SetInt("mute", 1);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
 }
