using TMPro;
using UnityEngine;

public class PowerView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _valueView;
    [SerializeField] private MonoBehaviour _power;

    private IHavePower _powerHaver;

    private void OnEnable() => 
        _powerHaver.Power.OnChanged += OnPowerChanged;

    private void Start() => 
        OnPowerChanged();

    private void OnValidate()
    {
        if (_power is IHavePower powerHaver)
        {
            _powerHaver = powerHaver;
        }
        else
        {
            _power = null;
            _powerHaver = null;
            return;
        }

        _powerHaver.Power.OnValidate();
    }

    private void OnDisable() => 
        _powerHaver.Power.OnChanged -= OnPowerChanged;

    private void OnPowerChanged() => 
        _valueView.text = $"Power: {_powerHaver.Power.Value}";
}