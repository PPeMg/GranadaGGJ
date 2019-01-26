using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public ProfileItem GetItem(int identifier)
    {
        ProfileItem returnValue = null;

        returnValue = items.Find(item => item.itemId == identifier);

        return returnValue;
    }

    /// <summary>
    /// Add a item to lists items.
    /// </summary>
    /// <param name="item">Item to add.</param>
    public void AddItem(ProfileItem item)
    {
        ProfileItem lastItem = items.Last();

        if (item != null)
        {
            item.itemId = lastItem != null ? lastItem.itemId + 1 : 1;
            items.Add(item);
        }
    }

    /// <summary>
    /// Remove a item of a list items. 
    /// </summary>
    /// <param name="item"></param>
    public void RemoveItem(ProfileItem item)
    {
        if (item != null)
        {
            items.Remove(item);
        }
    }

    /// <summary>
    /// Check if the selected item is a selected correct.    
    /// </summary>
    /// <param name="idItemSelected"> Selected item.</param>
    /// <returns> True if the </returns>
    public bool IsCorrect(int idItemSelected, ProfileItem profile)
    {
        bool result = profile.selectedItems.Contains(idItemSelected);      

        return result; 
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
    public List<int> selectedItems = new List<int>();
}
