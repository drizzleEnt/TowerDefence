using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayOrNigthTowerChecker : MonoBehaviour
{
    [SerializeField] private bool _isDayPlant;

    private bool _dayTime;

    public bool IsActive { get; private set; }

    private void Start()
    {
        _dayTime = FindObjectOfType<DayTimeSetter>().IsDay;
        if (_isDayPlant && !_dayTime || !_isDayPlant && _dayTime)
            IsActive = false;
        else
            IsActive = true;
    }

}
