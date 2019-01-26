using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMenuController : MonoBehaviour
{
    public GameObject avatarPrefab;

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

                instance.GetComponent<AvatarController>().InitAvatarButton(avatar.avatarId, avatar.nameItem);
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
