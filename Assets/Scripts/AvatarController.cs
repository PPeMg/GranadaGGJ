using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour
{
    private int id;
    private string avatarName;
    private bool selected;

    void Awake()
    {
        id = -1;
        avatarName = "";
        selected = false;
    }

    private void Start()
    {
        GetComponentInChildren<Button>().onClick.AddListener(Click);
    }

    public void InitAvatarButton(int id, string name)
    {
        this.id = id;
        this.avatarName = name;
    }

    public int GetID()
    {
        return this.id;
    }


    public bool IsSelected()
    {
        return this.selected;
    }

    public void SetSelected(bool selected)
    {
        this.selected = selected;
    }

    public void Click()
    {
        this.transform.GetComponentInParent<AvatarMenuController>().SelectAvatar(this.id);
        //GameManager.instance.profile.avatarId = this.id;
        Debug.Log("Pulsado Avatar con ID: " + this.id);
    }
}
