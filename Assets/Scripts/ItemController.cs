using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    private int id;
    private string itemName;
    private bool selected;

    void Awake()
    {
        id = -1;
        itemName = "";
        selected = false; 
    }

    private void Start()
    {
        GetComponentInChildren<Button>().onClick.AddListener(Click);
    }

    public void InitItemButton(int id, string name)
    {
        this.id = id;
        this.itemName = name;
    }

    public void SetSelected(bool selected)
    {
        this.selected = selected;
    }

    public void Click()
    {
        selected = GameManager.instance.AddSelectedItem(id);
        GameObject.Find("PreferencesSelected").GetComponent<PreferencesSelectedController>().RefreshSelectedItems();
        //GameManager.instance.profile.avatarId = this.id;
        Debug.Log("Pulsado Preferencia con ID: " + this.id);
    }
}
