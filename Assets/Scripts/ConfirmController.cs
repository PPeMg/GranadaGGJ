using UnityEngine;
using UnityEngine.UI;

public class ConfirmController : MonoBehaviour
{
    private Button confirmProfileButton;

    void Awake()
    {
        confirmProfileButton = GetComponent<Button>();
        confirmProfileButton.onClick.AddListener(StartCreateProfile);
    }

    public void StartCreateProfile()
    {
        GameManager.instance.profileDB.AddItem(GameManager.instance.profile);
        Debug.Log("AÑADIDO");
        GameManager.instance.SetActiveScreen(0);
    }
}
