using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTimeSetter : MonoBehaviour
{
    [SerializeField] private bool _isDay;

    public bool IsDay { get; private set; }

    private void Awake()
    {
        IsDay = _isDay;
    }
}
