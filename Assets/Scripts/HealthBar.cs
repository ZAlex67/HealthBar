using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health PlayerHealthPoint;

    private void Start()
    {
        OnHealthUpdated();
    }

    private void OnEnable()
    {
        PlayerHealthPoint.CheckedHealth += OnHealthUpdated;
    }

    private void OnDisable()
    {
        PlayerHealthPoint.CheckedHealth -= OnHealthUpdated;
    }

    protected abstract void OnHealthUpdated();
}