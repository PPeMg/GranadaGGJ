using System;
using UnityEngine;
using UnityEngine.UI;

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
                Image[] imageComponents = instance.GetComponentsInChildren<Image>();

                instance.GetComponent<ItemController>().InitItemButton(item.itemId, item.nameItem);
                imageComponents[imageComponents.Length - 1].sprite = item.spritePrefab;
            }
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("NullReferenceException: " + ex.Message);
        }
    }
}
