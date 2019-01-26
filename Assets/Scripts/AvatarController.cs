using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    private int id;
    private string avatarName;

    void Awake()
    {
        id = -1;
        avatarName = "";
    }

    public void InitAvatarButton(int id, string name)
    {
        this.id = id;
        this.avatarName = name;
    }
}
