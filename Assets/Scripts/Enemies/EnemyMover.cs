using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3[] _waypoints;

    
    public void Init(Transform[] points)
    {
        _waypoints = new Vector3[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            _waypoints[i] = points[i].position;
        }

        transform.DOPath(_waypoints, _duration, PathType.Linear, PathMode.TopDown2D).SetEase(Ease.Linear); ;
    }

}
