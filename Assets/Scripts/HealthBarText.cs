using TMPro;
using UnityEngine;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _velue;
    [SerializeField] private Health _healthPlayer; 

    private float _health;
    private string _maxHealth = "/100";

    private void Update()
    {
        _health = _healthPlayer.GetComponent<Health>().HealthPlayer;
        _velue.text = _health.ToString() + _maxHealth;
    }
}