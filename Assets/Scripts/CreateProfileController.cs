using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateProfileController : MonoBehaviour
{
    private Button createProfileButton;
    
    void Awake()
    {
        createProfileButton = GetComponent<Button>();
        createProfileButton.onClick.AddListener(StartCreateProfile);
    }

    public void StartCreateProfile()
    {
        GameManager.instance.SetActiveScreen(1);
    }
}
