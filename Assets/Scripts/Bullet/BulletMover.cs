using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private CommonShootingTower _tower;

    private void OnEnable()
    {
        _tower.IsShooted += MoveBullet;
    }

    private void OnDisable()
    {
        _tower.IsShooted -= MoveBullet;
    }

    private void MoveBullet(Enemy target)
    {
        _bulletPrefab.transform.position = transform.position;
        _bulletPrefab.gameObject.SetActive(true);
        _bulletPrefab.Move(target.transform.position);
        
    }
}
