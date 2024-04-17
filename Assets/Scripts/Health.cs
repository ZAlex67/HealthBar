using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _health;
    [SerializeField, Range(0, 100)] private int _maxHealth;

    public event Action HealthCheck;

    public int HealthPlayer => _health;

    public void TakeHit(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            _health = 0;
        }

        HealthCheck?.Invoke();
    }

    public void SetHealth(int health)
    {
        _health += health;

        if (_health > _maxHealth)
            _health = _maxHealth;

        HealthCheck?.Invoke();
    }
}