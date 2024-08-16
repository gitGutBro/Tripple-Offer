using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private string _frontText;
    [SerializeField] private TextMeshProUGUI _valueView;

    private IStat _stat;

    public void Init<T>(IStat stat, T value)
    {
        _stat = stat;

        OnChange(value);
    }

    private void OnChange<T>(T value) =>
        _valueView.text = $"{_frontText}: {value}";
}