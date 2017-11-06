using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {
    public Text bestscr;
    float bscore;

    // Use this for initialization
    void Start()
    {
        bscore = PlayerPrefs.GetFloat("best");
        if (bscore == 1200)
        {
            bestscr.text = "win";
        }
        else if (bscore >= 1000)
        {
            bestscr.text = "boss";
        }
        else bestscr.text = "" + bscore;
    }

    // Update is called once per frame
    void Update()
    {

    }
}