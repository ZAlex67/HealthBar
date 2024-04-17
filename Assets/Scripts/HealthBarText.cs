using TMPro;
using UnityEngine;

public class HealthBarText : HealthBar
{
    [SerializeField] private TextMeshProUGUI _velue;

    private string _maxHealth = "/100";

    protected override void HealthUpdate()
    {
        base.HealthUpdate();

        _velue.text = _health.ToString() + _maxHealth;
    }
}