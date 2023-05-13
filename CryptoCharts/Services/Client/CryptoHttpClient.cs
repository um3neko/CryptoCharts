using System;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCharts.MVVM.Models;
using Newtonsoft.Json;

namespace CryptoCharts.Services.Client;
public class CryptoHttpClient : ICryptoHttpClient
{

    private readonly HttpClient _httpClient;
    private readonly string _requestUri = "api.coincap.io/v2/assets/";

    public CryptoHttpClient()
    {
        _httpClient = new();
    }

    public async Task<CryptoCurrency> GetCryptoCurrencyById(string currencyId)
    {
        var response = await _httpClient.GetAsync("https://api.coincap.io/v2/assets/bitcoin");
        if (response.IsSuccessStatusCode)
        {
            string jsonResponse = await response.Content.ReadAsStringAsync();
            CryptoData? item =  JsonConvert.DeserializeObject<CryptoData>(jsonResponse);
            return item.Data;
        }
        else
        {
            return null;
        }
    }
}

