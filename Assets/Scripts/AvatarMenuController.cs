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
}
