﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameController : MonoBehaviour
{
    private Button startGameButton;

    void Awake()
    {
        startGameButton = GetComponent<Button>();
        startGameButton.onClick.AddListener(StartCreateProfile);
    }

    public void StartCreateProfile()
    {
        //GameManager.instance.SetActiveScreen(1);
        //GameManager.instance.PrintDebug(this.name);
        //GameManager.instance.ChangeElement(1, "TEST  DE CAMBIO");
        SceneManager.LoadScene("MainGame");
    }
}
