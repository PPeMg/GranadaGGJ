using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingProfileControler : MonoBehaviour
{
    private Button confirmButton;
    public Text textBox;

    private void Awake()
    {
        confirmButton = GetComponent<Button>();
        Text[] textList = GameObject.Find("ProfileNameInput").GetComponentsInChildren<Text>();

        foreach(Text text in textList)
        {
            if(text.name == "Value")
            {
                textBox = text; 
            }
        }

        confirmButton.onClick.AddListener(SaveProfile);
    }

    public void SaveProfile()
    {
        GameManager.instance.profile.name = textBox.text;
        Debug.Log(GameManager.instance.profile.name);
    }
}
