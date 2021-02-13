using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryTower : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;

    private Color _defoultColor;

    public Tower TowerToBuild;


    private void Awake()
    {
        _defoultColor = _sprite.color;
    }

    public void SetColor(bool isAvaliable)
    {
        if (!isAvaliable)
            _sprite.color = Color.red;
        else
            _sprite.color = Color.green;
    }

    public void SetNormal()
    {
        _sprite.color = _defoultColor;
    }
}
