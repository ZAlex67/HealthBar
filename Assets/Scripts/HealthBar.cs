using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _healthPlayer;

    protected float _health;

    private void Start()
    {
        HealthUpdate();
    }

    private void OnEnable()
    {
        _healthPlayer.HealthCheck += HealthUpdate;
    }

    private void OnDisable()
    {
        _healthPlayer.HealthCheck -= HealthUpdate;
    }

    protected virtual void HealthUpdate()
    {
        _health = _healthPlayer.GetComponent<Health>().HealthPlayer;
    }
}