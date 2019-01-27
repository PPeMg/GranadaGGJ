using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "GameJam/Databases/Object")]
public class Items : ScriptableObject
{
    public List<ObjectItem> items = new List<ObjectItem>();

    /// <summary>
    /// Get a item in a item list.
    /// </summary>
    /// <param name="identificador"> Identifier of the item to search. </param>
    /// <returns> The searched item. </returns>
    public ObjectItem GetItem(int identificador)
    {
        ObjectItem returnValue = null;
        returnValue = items.Find(item => item.itemId == identificador);

        return returnValue;
    }

    /// <summary>
    /// Add a item to lists items.
    /// </summary>
    /// <param name="item">Item to add.</param>
    public void AddItem(ObjectItem item)
    {
        ObjectItem lastItem = items.Last();

        if (item!=null)
        {
            item.itemId = lastItem != null ? lastItem.itemId + 1 : 1;
            items.Add(item);
        }
    }

    /// <summary>
    /// Remove a item of a list items. 
    /// </summary>
    /// <param name="item"></param>
    public void RemoveItem(ObjectItem item)
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
 public class ObjectItem
{
    public int itemId;
    public string nameItem;
    public Vector3 targetPosition;
    public GameObject modelPrefab;
    public Sprite spritePrefab;
}


