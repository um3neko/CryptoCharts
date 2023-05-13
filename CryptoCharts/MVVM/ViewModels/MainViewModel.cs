using CryptoCharts.MVVM.Base;
using CryptoCharts.MVVM.Models;
using CryptoCharts.Services.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CryptoCharts.MVVM.ViewModels;

public class MainViewModel : ViewModel
{
    private readonly ICryptoHttpClient _cryptoHttpClient;

    public MainViewModel(ICryptoHttpClient cryptoHttpClient)
    {
        _cryptoHttpClient = cryptoHttpClient;
        Click = new RelayCommand(param => Default(), x => true);

    }

    private CryptoCurrency _cryptoCurrency;
    public CryptoCurrency CryptoCurrency {
        get => _cryptoCurrency;
        set
        {
            _cryptoCurrency = value;
            OnPropertyChanged();
        }
    }

    private string _test = new("qwer");
    public string Test
    {
        get => _test;
        set
        {
            _test = value;
            OnPropertyChanged();
        }
    }

    public ICommand Click { get; private set; }

    private async void Default()
    {
        CryptoCurrency = await _cryptoHttpClient.GetCryptoCurrencyById("bitcoin");
    }
}
