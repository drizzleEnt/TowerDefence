using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemyMover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;

    private EnemyMover _mover;

    public event UnityAction<Enemy> IsDead;

    public int Health { get; private set; }
    public int Reward { get; private set; }

    private void Awake()
    {
        Reward = _reward;
        Health = _health;
        _mover = GetComponent<EnemyMover>();
    }

    public void Init(Transform[] points)
    {
        _mover.Init(points);
    }


    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            IsDead?.Invoke(this);
            gameObject.SetActive(false);
        }
    }
}
