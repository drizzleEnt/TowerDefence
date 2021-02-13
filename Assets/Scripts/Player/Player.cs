using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction<int> IsResoursesAmountChanged;

    public int ResoursesAmount { get; private set; } = 200;

    private void Start()
    {
        IsResoursesAmountChanged?.Invoke(ResoursesAmount);
    }

    public void IncreaseResoursesAmount(int resoursesAmount)
    {
        ResoursesAmount += resoursesAmount;
        IsResoursesAmountChanged?.Invoke(ResoursesAmount);
    }

    public void SpendResourses(int resoursesAmount)
    {
        ResoursesAmount -= resoursesAmount;
        IsResoursesAmountChanged?.Invoke(ResoursesAmount);
    }
}
