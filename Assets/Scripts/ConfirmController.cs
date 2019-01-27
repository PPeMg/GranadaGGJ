using UnityEditor;
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
        //Undo.RecordObject(GameManager.instance.profileDB, "Saving New Profile");
        GameManager.instance.profileDB.AddItem(GameManager.instance.profile);

        EditorUtility.SetDirty(GameManager.instance.profileDB);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log("AÑADIDO");
        GameManager.instance.SetActiveScreen(0);
    }
}
