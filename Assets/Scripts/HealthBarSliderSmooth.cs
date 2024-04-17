using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderSmooth : HealthBar
{
    [SerializeField] private Slider _slider;

    private float _coefficient = 20f;
    private Coroutine _coroutine;

    protected override void HealthUpdate()
    {
        base.HealthUpdate();

        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangeHealthSmooth());
    }

    private IEnumerator ChangeHealthSmooth()
    {
        while (_slider.value != _health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health, _coefficient * Time.deltaTime);
            yield return null;
        }
    }
}