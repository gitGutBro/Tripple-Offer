using System;
using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _value;
    [SerializeField] private MonoBehaviour _wallet;

    private IHaveWallet _walletHaver;

    private void OnEnable() => 
        _walletHaver.Wallet.OnChanged += OnWalletChange;

    private void Start() => 
        OnWalletChange();

    private void OnValidate()
    {
        if (_wallet is IHaveWallet walletHaver)
        {
            _walletHaver = walletHaver;
        }
        else
        {
            _wallet = null;
            _walletHaver = null;
            return;
        }

        _walletHaver.Wallet.OnValidate();
    }

    private void OnDisable() => 
        _walletHaver.Wallet.OnChanged -= OnWalletChange;

    private void OnWalletChange() => 
        _value.text = $"Balance: {_walletHaver.Wallet.Balance}";
}