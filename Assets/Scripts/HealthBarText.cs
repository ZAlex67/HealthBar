using TMPro;
using UnityEngine;

public class HealthBarText : HealthBar
{
    [SerializeField] private TextMeshProUGUI _velue;

    protected override void OnHealthUpdated()
    {
        _velue.text = PlayerHealthPoint.CurrentHealth.ToString() + "/" + PlayerHealthPoint.MaxHealth;
    }
}