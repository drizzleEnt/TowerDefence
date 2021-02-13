using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourseShower : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.IsResoursesAmountChanged += ShowSunAmount;
    }

    private void OnDisable()
    {
        _player.IsResoursesAmountChanged -= ShowSunAmount;
    }

    private void ShowSunAmount(int sunCount)
    {
        _text.text = sunCount.ToString();
    }
}
