using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Results : MonoBehaviour
{
    public Ease ease;

    public float duration;

    public Vector3 targetPos;

    public Vector3 hidePos;


    public PlayerResults[] playerResults;


    private void Awake()
    {
        transform.position = hidePos;
    }

    private void OnEnable()
    {
        Animate();
    }

    void Animate()
    {
        StartCoroutine(DoAnim());
    }

    IEnumerator DoAnim()
    {
        WaitForSeconds delay = new WaitForSeconds(duration);

        transform.DOMove(targetPos, duration).SetEase(ease);

        yield return delay;

        delay = new WaitForSeconds(0.5f);

        for (int i = 0; i < playerResults.Length; i++)
        {
            playerResults[i].enabled = true;
            yield return delay;
        }
    }
}
