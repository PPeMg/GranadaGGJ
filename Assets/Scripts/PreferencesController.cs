using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreferencesController : MonoBehaviour
{
    public GameObject itemPrefab;

    private void OnEnable()
    {
        try
        {
            Items itemModelList = GameManager.instance.itemList;

            foreach (RectTransform child in this.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

            foreach (ObjectItem item in itemModelList.items)
            {
                GameObject instance = Instantiate(itemPrefab, this.transform);

                instance.GetComponent<ItemController>().InitItemButton(item.itemId, item.nameItem);
            }
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("NullReferenceException: " + ex.Message);
        }
    }
}
