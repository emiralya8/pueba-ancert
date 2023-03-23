using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WpfCronometro.clases;
using WpfCronometro.interfaces;

namespace WpfCronometro
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider? serviceProvider { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceColletion = new ServiceCollection();
            ConfigureServices(serviceColletion);
            serviceProvider = serviceColletion.BuildServiceProvider();
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(ServiceCollection service)
        {
            service.AddTransient(typeof(MainWindow))
                   .AddScoped<ICronometro, Cronometro>()
                   .AddScoped<MainWindow>();
        }
    }
}
