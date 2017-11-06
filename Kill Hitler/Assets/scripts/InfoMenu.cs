using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Insttukus()
    {
        Application.OpenURL("https://www.instagram.com/tukusborus/");
    }

    public void InstOleg()
    {
        Application.OpenURL("https://www.instagram.com/oleg.biomode/");
    }

    public void ChangeScene()
    {
        music.Instance.FadeOut(1, 0, 100);
        FadeInOut.sceneEnd = true;
    }

}
