using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _healthPlayer;

    private float _health;

    private void Update()
    {
        _health = _healthPlayer.GetComponent<Health>().HealthPlayer;
        _slider.value = _health;
    }
}