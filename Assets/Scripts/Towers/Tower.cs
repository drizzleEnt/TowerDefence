using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Tower : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _actionAmount;
    [SerializeField] private float _timeBetweenAction;

    public int Cost;
    public string Label;
    public int Health { get; private set; }
    public int ActionAmount { get; protected set; }
    public float TimeBetweenAction { get; protected set; }

    private void Awake()
    {
        Health = _health;
        ActionAmount = _actionAmount;
        TimeBetweenAction = _timeBetweenAction;
    }

    protected void Die()
    {
        Debug.Log($"{gameObject.name} ymer");
        gameObject.SetActive(false);
    }

    public void TakeDamge(int damage)
    {
        Health -= damage;
        if (Health <= 0)
            Die();
    }

    public virtual void Upgrade(int actionAmount, int timeBetweenActions)
    {
        ActionAmount += actionAmount;
        TimeBetweenAction += timeBetweenActions;
    }

}
