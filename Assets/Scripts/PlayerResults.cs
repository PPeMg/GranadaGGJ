using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PlayerResults : MonoBehaviour
{
    public float debugProgress;

    public TextMeshProUGUI nameText;

    public TextMeshProUGUI progressText;

    public Slider sliderProgress;


    private void Awake()
    {
        nameText.transform.localScale = Vector3.zero;
        progressText.transform.localScale = Vector3.zero;
        sliderProgress.transform.localScale = Vector3.zero;
        sliderProgress.value = 0;

    }

    private void OnEnable()
    {

        StartCoroutine(DoResults());

    }

    IEnumerator DoResults()
    {
        nameText.transform.localScale = Vector3.zero;
        nameText.transform.DOScale(Vector3.one, 1f);


        yield return new WaitForSeconds(0.6f);

        progressText.transform.localScale = Vector3.zero;
        progressText.transform.DOScale(Vector3.one, 1f);

        sliderProgress.transform.localScale = Vector3.zero;
        sliderProgress.transform.DOScale(Vector3.one, 1f);

        yield return new WaitForSeconds(0.6f);

        sliderProgress.value = 0;
        sliderProgress.DOValue(debugProgress / 100, 1).OnUpdate(() => { progressText.text = Mathf.RoundToInt((sliderProgress.value * 100)).ToString() + "%"; });
    }
}
