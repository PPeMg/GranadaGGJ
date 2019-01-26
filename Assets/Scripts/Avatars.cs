using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "GameJam/Databases/Avatars")]
public class Avatars : ScriptableObject
{
    public List<AvatarItem> items = new List<AvatarItem>();

    /// <summary>
    /// Get a item in a item list.
    /// </summary>
    /// <param name="identificador"> Identifier of the item to search. </param>
    /// <returns> The searched item. </returns>
    public AvatarItem GetItem(int identificador)
    {
        AvatarItem returnValue = null;
        returnValue = items.Find(item => item.avatarId == identificador);

        return returnValue;
    }

    /// <summary>
    /// Add a item to lists items.
    /// </summary>
    /// <param name="item">Item to add.</param>
    public void AddItem(AvatarItem item)
    {
        AvatarItem lastItem = items.Last();

        if (item != null)
        {
            item.avatarId = lastItem != null ? lastItem.avatarId + 1 : 1;
            items.Add(item);
        }
    }

    /// <summary>
    /// Remove a item of a list items. 
    /// </summary>
    /// <param name="item"></param>
    public void RemoveItem(AvatarItem item)
    {
        if (item != null)
        {
            items.Remove(item);
        }
    }


}

/// <summary>
/// The object's characteristics
/// </summary>
[System.Serializable]
public class AvatarItem
{
    public int avatarId;
    public string nameItem;
}


