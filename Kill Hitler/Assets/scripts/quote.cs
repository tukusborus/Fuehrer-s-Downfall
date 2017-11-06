using UnityEngine;
using System.Collections;

public class quote : MonoBehaviour {
    public Transform quotes;
	// Use this for initialization
	void Start () {
        Invoke("endGame", 10f);
	}
    void endGame()
    {
        FadeInOut.sceneEnd = true;
    }
}
