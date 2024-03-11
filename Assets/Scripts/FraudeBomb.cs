using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;

public class FraudeBomb : MonoBehaviour
{
    public float duration;
    public float durationCrash;

    public Vector3 endpos;

    public Vector3 secondpos;
    public Vector3 secondRotation;

    public GameObject Player;
    public Vector3 crashPos;

    public Vector3 crashScale;

    [CanBeNull] public GameObject ExplosionFx;
    private void Start()
    {
        StartCoroutine(StartAnimBomb());
    }

    private void Update()
    {
        crashPos = Player.transform.position;
    }

    private IEnumerator StartAnimBomb()
    {
        transform.DOMove(endpos, duration);
        yield return new WaitForSeconds(duration);

        transform.position = secondpos;
        transform.rotation = Quaternion.Euler(secondRotation);
        transform.localScale = crashScale;
        
        transform.DOMove(crashPos, durationCrash);
    }

    private void OnTriggerEnter(Collider other)
    {
        ExplosionFx.transform.position = transform.position;
        ExplosionFx.SetActive(true);
        Destroy(gameObject);
    }
}
