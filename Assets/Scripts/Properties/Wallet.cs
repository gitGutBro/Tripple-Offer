using System;
using UnityEngine;

public class Wallet : IStat
{
    private decimal _balance;

    public event Action OnChanged;

    public decimal Balance => _balance;

    public Wallet(decimal balance) => 
        _balance = balance;

    public void Increase(decimal value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Value is below zero!");

        _balance += value;

        OnChanged?.Invoke();
    }

    public void Decrease(decimal price)
    {
        if (price < 0)
            throw new ArgumentOutOfRangeException("Price is below zero!");

        if (_balance < price)
        {
            Debug.LogError("Price higher then balance");
            return;
        }

        _balance -= price;

        OnChanged?.Invoke();
    }

    public void OnValidate() => 
        OnChanged?.Invoke();
}