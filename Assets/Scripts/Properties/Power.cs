using System;
using UnityEngine;

[Serializable]
public class Power
{
    [SerializeField][Min(0)] private int _value;

    public event Action OnChanged;

    public int Value => _value;

    public void Increase(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Value is below zero!");

        _value += value;

        OnChanged?.Invoke();
    }

    public void Decrease(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Value is below zero!");

        if (_value < value)
        {
            _value = 0;
            return;
        }

        _value -= value;

        OnChanged?.Invoke();
    }

    public void OnValidate() =>
        OnChanged?.Invoke();
}