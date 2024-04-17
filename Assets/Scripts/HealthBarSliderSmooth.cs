using System.Collections;
using UnityEngine;

public class HealthBarSliderSmooth : HealthBarSlider
{
    private float _coefficient = 3f;
    private Coroutine _coroutine;

    protected override void OnHealthUpdated()
    {
        base.ChangeMaxHealth();

        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangeHealthSmooth());
    }

    private IEnumerator ChangeHealthSmooth()
    {
        while (_slider.value != PlayerHealthPoint.CurrentHealth)
        {
            _slider.value = Mathf.Lerp(_slider.value, PlayerHealthPoint.CurrentHealth, _coefficient * Time.deltaTime);
            yield return null;
        }
    }
}