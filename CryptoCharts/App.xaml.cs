using CryptoCharts.MVVM.Base;
using CryptoCharts.MVVM.ViewModels;
using CryptoCharts.Services.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace CryptoCharts;

public partial class App : Application
{
    private readonly ServiceProvider _serviceProvider;
    public App()
    {
        IServiceCollection services = new ServiceCollection();
        
        services.AddSingleton<MainWindow>();
        services.AddSingleton<MainViewModel>();
        services.AddScoped<ICryptoHttpClient, CryptoHttpClient>();
        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var startupForm = _serviceProvider.GetRequiredService<MainWindow>();
        startupForm.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
        startupForm.Show();
        base.OnStartup(e);
    }

}
