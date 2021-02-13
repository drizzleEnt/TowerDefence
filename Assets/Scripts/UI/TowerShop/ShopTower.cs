using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopTower : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TemporaryTower _tower;
    [SerializeField] private TMP_Text _textCost;
    [SerializeField] private TMP_Text _textLabel;


    private void Start()
    {
        _textCost.text = _tower.TowerToBuild.Cost.ToString();
        _textLabel.text = _tower.TowerToBuild.Label;
    }
}
