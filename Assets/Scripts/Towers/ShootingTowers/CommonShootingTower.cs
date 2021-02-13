using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CommonShootingTower : ShootingTower
{
    private Enemy _currentTarget;


    public event UnityAction<Enemy> IsShooted;

    protected override void Shoot()
    {
        if (_currentTarget == null)
            _currentTarget = Targets.Peek();
        StartCoroutine(Shooting());
    }

    private IEnumerator Shooting()
    {
        IsShooting = true;
        while (_currentTarget.Health > 0)
        {
            ActionAmount--;
            IsShooted?.Invoke(_currentTarget);
            _currentTarget.TakeDamage(Damage);

            if (ActionAmount == 0)
            {
                Die();
                break;
            }
            yield return new WaitForSeconds(TimeBetweenAction);
            if (Vector2.Distance(transform.position, _currentTarget.transform.position) > ActionRadius)
                break;
        }        
        IsShooting = false;
        _currentTarget = null;
    }
}
