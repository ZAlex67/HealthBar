using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : HealthBar
{
    [SerializeField] private Slider _slider;

    protected override void HealthUpdate()
    {
        base.HealthUpdate();

        _slider.value = _health;
    }
}