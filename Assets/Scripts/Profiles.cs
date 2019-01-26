using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "User/Databases/Profile")]
public class Profiles : ScriptableObject
{
    public List<Item> items = new List<Item>();

    public Item GetItem(int identificador)
    {
        Item returnValue = null; 
        foreach (Item item in items)
        {
            if(item.identificador == identificador)
            {
                returnValue = item;
            }
        }

        return returnValue;
    }
}

[System.Serializable]
public class Item
{
    public int identificador;
    public string name;
    public int avatarId;
    public int[] selectedItems;
}
