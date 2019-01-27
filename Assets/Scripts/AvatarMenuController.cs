using System;
using UnityEngine;
using UnityEngine.UI;

public class AvatarMenuController : MonoBehaviour
{
    public GameObject avatarPrefab;
    public Sprite avatarIconPrefab;

    private void OnEnable()
    {
        try
        {
            Avatars avatarModelList = GameManager.instance.avatarList;
            
            foreach (RectTransform child in this.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

            foreach (AvatarItem avatar in avatarModelList.items)
            {
                GameObject instance = Instantiate(avatarPrefab, this.transform);
                Image[] imageComponents = instance.GetComponentsInChildren<Image>();

                instance.GetComponent<AvatarController>().InitAvatarButton(avatar.avatarId, avatar.nameItem);
                imageComponents[imageComponents.Length -1].sprite = avatar.spritePrefab;
            }
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("NullReferenceException: " + ex.Message);
        }
    }

    public void SelectAvatar(int id)
    {
        foreach (AvatarController avatar in this.transform.GetComponentsInChildren<AvatarController>())
        {
            if(avatar.GetID() == id)
            {
                avatar.SetSelected(true);
            } else
            {
                avatar.SetSelected(false);
            }
        }
    }

    public int GetSelectedAvatar()
    {
        int selectedID = -1;

        foreach(AvatarController avatar in GetComponentsInChildren<AvatarController>())
        {
            if (avatar.IsSelected())
            {
                selectedID = avatar.GetID();
            }
        }

        return selectedID;
    }
}
