using UnityEngine;

public class PlayerProperties : MonoBehaviour, IHavePower, IHaveWallet
{
    [field: SerializeField] public Power Power { get; private set; }

    public Wallet Wallet { get; private set; }

    private void Awake()
    {
        decimal startBalance = 10;

        Wallet = new(startBalance);
    }
}