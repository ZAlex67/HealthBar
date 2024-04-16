using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderSmooth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _healthPlayer;

    private float _health;
    private float _coefficient = 20f;

    private void Update()
    {
        _health = _healthPlayer.GetComponent<Health>().HealthPlayer;
        _slider.value = Mathf.MoveTowards(_slider.value, _health, _coefficient * Time.deltaTime);
    }
}