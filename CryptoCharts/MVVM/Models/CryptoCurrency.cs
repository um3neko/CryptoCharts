namespace CryptoCharts.MVVM.Models;

public class CryptoCurrency
{
    public string Id { get; set; }
    public int Rank { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public decimal Supply { get; set; }
    public decimal MaxSupply { get; set; }
    public decimal MarketCapUsd { get; set; }
    public decimal VolumeUsd24Hr { get; set; }
    public decimal PriceUsd { get; set; }
    public float ChangePercent24Hr { get; set;  }
    public float Vwap24Hr { get; set; }

}
