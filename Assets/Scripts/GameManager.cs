using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] menus;

    void Awake()
    {
        for (int i = 1; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
        }
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
}
