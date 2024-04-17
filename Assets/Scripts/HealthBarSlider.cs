using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : HealthBar
{
    [SerializeField] protected Slider _slider;

    protected virtual void ChangeMaxHealth()
    {
        _slider.maxValue = PlayerHealthPoint.MaxHealth;
    }

    protected override void OnHealthUpdated()
    {
        ChangeMaxHealth();

        _slider.value = PlayerHealthPoint.CurrentHealth;
    }
}