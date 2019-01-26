using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Object/Databases/Object")]
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
}


/// <summary>
/// The object's characteristics
/// </summary>
[System.Serializable]
public class ObjectItem
{
    public int itemId;
    public string nameItem; 
}


