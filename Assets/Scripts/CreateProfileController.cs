using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateProfileController : MonoBehaviour
{
    private Button createProfileButton;
    
    void Start()
    {
        createProfileButton = GetComponent<Button>();
        createProfileButton.onClick.AddListener(() => PrintMessage("Test"));
    }
    
    void Update()
    {
        
    }

    public void PrintMessage(string message)
    {
        Debug.Log(message);
    }
}
