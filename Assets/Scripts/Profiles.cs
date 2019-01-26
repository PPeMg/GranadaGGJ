using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "User/Databases/Profile")]
public class Profiles : ScriptableObject
{
    public List<ProfileItem> items = new List<ProfileItem>();

    /// <summary>
    /// Get a item in a item list.
    /// </summary>
    /// <param name="identificador"> Identifier of the item to search. </param>
    /// <returns> The searched item. </returns>
    public ProfileItem GetItem(int identificador)
    {
        ProfileItem returnValue = null;

        returnValue = items.Find(item => item.itemId == identificador);

        return returnValue;
    }
}

/// <summary>
/// The player's characteristics
/// </summary>
[System.Serializable]
public class ProfileItem
{
    public int itemId;
    public int score; 
    public string name;
    public int avatarId;
    public int[] selectedItems;
}
