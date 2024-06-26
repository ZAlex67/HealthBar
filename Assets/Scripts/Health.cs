using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _health;
    [SerializeField, Range(0, 100)] private int _maxHealth;

    public event Action CheckedHealth;

    public int CurrentHealth => _health;
    public int MaxHealth => _maxHealth;

    public void TakeHit(int damage)
    {
        if (damage >= 0)
            _health = Mathf.Clamp(_health -= damage, 0, _maxHealth);

        CheckedHealth?.Invoke();
    }

    public void SetHealth(int health)
    {
        if (health >= 0)
            _health = Mathf.Clamp(_health += health, 0, _maxHealth);

        CheckedHealth?.Invoke();
    }
}