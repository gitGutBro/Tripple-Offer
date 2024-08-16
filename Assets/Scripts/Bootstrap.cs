using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private View _walletView;
    [SerializeField] private View _powerView;

    private PlayerStats _stats;

    private void Awake()
    {
        _stats = new(startBalance: 10);

        _walletView.Init(_stats.Wallet, _stats.Wallet.Balance);
        _powerView.Init(_stats.Power, _stats.Power.Value);
    }
}