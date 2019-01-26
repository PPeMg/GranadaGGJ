using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] menus;
    public Profiles profileDB;
    public Items itemList;
    //public Avatars avatarList;

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
