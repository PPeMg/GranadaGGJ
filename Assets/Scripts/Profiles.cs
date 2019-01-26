using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "GameJam/Databases/Profile")]
public class Profiles : ScriptableObject
{
    public List<ProfileItem> items;

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
    /// Get the user's score.
    /// </summary>
    /// <param name="identifier"> Identifier's user to get.</param>
    /// <returns> The score.</returns>
    public int GetScore(int identifier)
    {
        return this.GetItem(identifier).score; 
    }

    /// <summary>
    /// Set name's user. 
    /// </summary>
    /// <param name="id"> Identifier's user. </param>
    /// <param name="newName"> New name. </param>
    public void SetName(int id, string newName)
    {
        this.GetItem(id).name = newName; 
    }
    
    /// <summary>
    /// Set the score of a user. 
    /// </summary>
    /// <param name="id"> The identifier's user. </param>
    /// <param name="newScore"> The new score. </param>
    public void SetScore(int id, int newScore)
    {
        this.GetItem(id).score = newScore;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="newSelectedItem"></param>
    public void AddSelectedItem(int id, int newSelectedItem)
    {
        this.GetItem(id).selectedItems.Add(newSelectedItem); 
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
