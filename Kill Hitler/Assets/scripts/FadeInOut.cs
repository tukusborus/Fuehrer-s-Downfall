using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{

    public static bool sceneEnd;
    public static bool sceneEnd2;
    public float fadeSpeed = 1.5f;
    public string nextLevel;
    public string nextLevel2;

    private Image _image;
    private bool sceneStarting;

    void Awake()
    {
        _image = GetComponent<Image>();
        _image.enabled = true;
        sceneStarting = true;
        sceneEnd = false;
        sceneEnd2 = false;

    }

    void Update()
    {
        if (sceneStarting) StartScene();
        if (sceneEnd) EndScene();
        if (sceneEnd2) EndScene2();

    }

    void StartScene()
    {
        _image.color = Color.Lerp(_image.color, Color.clear, fadeSpeed * Time.deltaTime);

        if (_image.color.a <= 0.01f)
        {
            _image.color = Color.clear;
            _image.enabled = false;
            sceneStarting = false;
            Cursor.visible = true;
        }
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