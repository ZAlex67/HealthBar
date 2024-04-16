using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    [SerializeField] private TextMeshPro _velue;

    public int HealthPlayer => _health;

    public void TakeHit(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            _health = 0;
        }
    }

    public void SetHealth(int health)
    {
        _health += health;

        if (_health > _maxHealth)
            _health = _maxHealth;
    }
}