using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class backred : MonoBehaviour {
    float time = 3.7f;
    int lich = 0;
    public Transform back;
    public Button btnback;
    public Button btnres;
    public Button btnadd;
    public static bool btnads;

    // Use this for initialization
    void Start () {
        lich = 0;
        btnres.gameObject.SetActive(false);
        btnback.gameObject.SetActive(false);
        btnadd.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (time > 0)
        {
            time -= Time.deltaTime;
        } else if ((time <= 0) && (lich == 0))
        {
            Instantiate(back, new Vector3(0, 0, 0), this.transform.rotation);
            lich++;
            btnres.gameObject.SetActive(true);
            btnback.gameObject.SetActive(true);
            if (btnads)
            {
                btnadd.gameObject.SetActive(true);
            }   
        }
    }
}
