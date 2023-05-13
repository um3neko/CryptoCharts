using CryptoCharts.MVVM.Models;
using System.Threading.Tasks;

namespace CryptoCharts.Services.Client
{
    public interface ICryptoHttpClient
    {
        Task<CryptoCurrency> GetCryptoCurrencyById(string currencyId);
    }
}