using CronometroApp.clases;
using CronometroApp.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CronometroApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var services = new ServiceCollection();
            
            ServiceConfigure(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var frmCronometro = serviceProvider.GetRequiredService<FrmCronometro>();
                Application.Run(frmCronometro);
            }

        }

        private static void ServiceConfigure(ServiceCollection services)
        {
            services.AddScoped<ICronometro, Cronometro>()
                    .AddScoped<FrmCronometro>();
        }
    }
}
