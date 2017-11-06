using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class gameManager : MonoBehaviour {
   
    public static float score;
    public float bestscr;
    public Text sText;
    public static bool ShowAd;

	// Use this for initialization
	void Start () {
        bestscr = PlayerPrefs.GetFloat("best");
        if (!ShowAd)
        {
            score = 0;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        sText.text = "" + score;
        if (score > bestscr)
        {
            save();
        }
    }
        
	
    public void addScore(float scores)
    {
        score = score + scores;
    }
    public void save()
    {
        PlayerPrefs.SetFloat("best", score);
    }
}
