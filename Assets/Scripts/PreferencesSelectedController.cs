using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreferencesSelectedController : MonoBehaviour
{
    public GameObject itemPrefab;

    private void OnEnable()
    {
        RefreshSelectedItems();
    }

    public void RefreshSelectedItems()
    {
        try
        {
            List<int> itemList = GameManager.instance.profile.selectedItems;
            Items itemModelList = GameManager.instance.itemList;

            foreach (RectTransform child in this.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

            foreach (ObjectItem item in itemModelList.items)
            {
                if (itemList.IndexOf(item.itemId) != -1)
                {
                    GameObject instance = Instantiate(itemPrefab, this.transform);
                    Image[] imageComponents = instance.GetComponentsInChildren<Image>();

                    instance.GetComponent<ItemController>().InitItemButton(item.itemId, item.nameItem);
                    imageComponents[imageComponents.Length - 1].sprite = item.spritePrefab;
                }
            }
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("NullReferenceException: " + ex.Message);
        }
    }
}
