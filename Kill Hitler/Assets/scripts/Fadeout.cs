using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour {

    public static bool sceneEnd;
    public static bool sceneEnd2;
    public float fadeSpeed = 1.5f;
    public string nextLevel;
    public string nextLevel2;


    private Image _image;


    void Awake()
    {
        _image = GetComponent<Image>();
        _image.enabled = true;
        sceneEnd2 = false;
        sceneEnd = false;

    }

    void Update()
    {
       
        if (sceneEnd) EndScene();
        if (sceneEnd2) EndScene2();
    }



    void EndScene()
    {
        _image.enabled = true;
        _image.color = Color.Lerp(_image.color, Color.black, fadeSpeed * Time.deltaTime);

        if (_image.color.a >= 0.95f)
        {
            Cursor.visible = false;
            _image.color = Color.black;
            Application.LoadLevel(nextLevel);
        }
    }

    void EndScene2()
    {
        _image.enabled = true;
        _image.color = Color.Lerp(_image.color, Color.black, fadeSpeed * Time.deltaTime);

        if (_image.color.a >= 0.95f)
        {
            Cursor.visible = false;
            _image.color = Color.black;
            Application.LoadLevel(nextLevel2);
        }
    }
}
