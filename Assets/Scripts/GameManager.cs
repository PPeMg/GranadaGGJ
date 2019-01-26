using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] menus;

    public static GameManager instance;

    void Awake()
    {
<<<<<<< HEAD
        //for (int i = 1; i < menus.Length; i++)
        //{
        //    menus[i].SetActive(false);
        //}

        menus[0].SetActive(false);
        menus[1].SetActive(true);
        menus[2].SetActive(false);

=======
        // This make it a Singleton
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }

        SetActiveScreen(0);
>>>>>>> 162fc048ab6fa10ade904c8280a678fe38f6ad51
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
}
