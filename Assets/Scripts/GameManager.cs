using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] menus;
    public Profiles profileDB;
    public Items itemList;
    public Avatars avatarList;

    public ProfileItem profile; 

    public static GameManager instance;

    void Awake()
    {
        // This make it a Singleton
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }

        SetActiveScreen(0);
    }

    void Start()
    {
        //StartCoroutine(Wait(5));
    }
    
    void Update()
    {
        
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        menus[0].SetActive(false);
        menus[1].SetActive(true);
        yield return null;
    }

    /// <summary>
    /// Add the selected item to profile. 
    /// </summary>
    /// <param name="selectedItem"> Selected item to add. </param>
    /// <returns> True if the selectedItem is inserted. </returns>
    public bool  AddSelectedItem(int selectedItem)
    {
        bool inserted = default(bool);
        if(profile.selectedItems.Count<5)
        {
            profile.selectedItems.Add(selectedItem);
            inserted = true; 
        }
        else
        {
            inserted = false;
            Debug.Log("Lista de preferencias completa.");
        }

        return inserted; 
    }

    /// <summary>
    /// Set the active screen.
    /// </summary>
    /// <param name="index"> Index of the screen to active. </param>
    public void SetActiveScreen(int index)
    {
        for(int i = 0; i < menus.Length; i++)
        {
            if(i == index)
            {
                menus[i].SetActive(true);
            } else
            {
                menus[i].SetActive(false);
            }
        }
    }

    public void PrintDebug(string objectName)
    {
        Debug.Log("This is " + objectName);
    }

    public void ChangeElement(int id, string value)
    {
        //profileList.GetItem(id).name = value;
    }
}
