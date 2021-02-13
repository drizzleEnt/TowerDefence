using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof (CircleCollider2D))]
public abstract class ShootingTower : Tower
{
    [SerializeField] private int _damage;
    [SerializeField] private float _actionRadius;

    private CircleCollider2D _collider;

    protected Queue<Enemy> Targets = new Queue<Enemy>();
    protected bool IsShooting = false;


    public float ActionRadius { get; protected set; }
    public int Damage { get; protected set; }

    private void Start()
    {
        ActionRadius = _actionRadius;
        Damage = _damage;
        _collider = GetComponent<CircleCollider2D>();
        _collider.radius = ActionRadius / 10;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy target))
            Targets.Enqueue(target);        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
            if (IsShooting == false)
                Shoot();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy target))
            Targets.Dequeue();
    }

    public override void Upgrade(int actionAmount, int timeBetweenActions)
    {
        base.Upgrade(actionAmount, timeBetweenActions);
        ActionRadius = ActionRadius + ActionRadius * .2f;
        _collider.radius = ActionRadius;
    }

    protected abstract void Shoot();
}
