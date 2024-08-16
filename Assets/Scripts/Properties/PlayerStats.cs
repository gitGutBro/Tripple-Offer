public class PlayerStats
{
    public Wallet Wallet { get; private set; }
    public Power Power { get; private set; }

    public PlayerStats(decimal startBalance)
    {
        Wallet = new(startBalance);
        Power = new();
    }
}