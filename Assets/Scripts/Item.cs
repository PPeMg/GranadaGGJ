using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Item : MonoBehaviour
{
    private bool _selected;

    private void OnMouseDown()
    {
        Click();
    }

    void Click()
    {
        if (_selected)
            return;

        _selected = true;
    }
}
