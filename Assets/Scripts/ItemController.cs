using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private int id;
    private string itemName;

    void Awake()
    {
        id = -1;
        itemName = "";
    }

    public void InitItemButton(int id, string name)
    {
        this.id = id;
        this.itemName = name;
    }
}
