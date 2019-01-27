using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CreditsController : MonoBehaviour
{
    private Button creditButton;
    private Rect windowRect = new Rect(20, 20, 120, 50);
    public string text = string.Empty;
    TextMesh screen; 
    void Awake()
    {
        creditButton = GetComponent<Button>();
        creditButton.onClick.AddListener(ShowCredits);
    }

    public void ShowCredits()
    {
        //windowRect = GUI.Window(0, windowRect, WindowFunction, "Credits");
        //text = "prueeeba";
        //screen = text; 
    }

}
