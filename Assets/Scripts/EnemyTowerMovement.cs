using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class EnemyTowerMovement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    private void Start()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        transform.DOMove(pointB.position, 2f).SetEase(Ease.Linear).OnComplete(() =>
        {
            transform.DOMove(pointA.position, 2f).SetEase(Ease.Linear).OnComplete(MoveObject);
        });
    }
}
