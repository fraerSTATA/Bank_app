using Bank_app.Infrastructure.Services;
using Bank_app.Infrastructure.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Bank_app.Data;
using System.Windows.Navigation;
using Bank_app.DAL.Context;
namespace Bank_app
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IHost _Host;

        public static IHost Host => _Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
      
        public static IServiceProvider Services => Host.Services;
        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddDatabase(host.Configuration.GetSection("Database"))
            .AddServices()
            .AddViewModels()
            ;
            
        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;

            using(var scope = Services.CreateScope())
              scope.ServiceProvider.GetRequiredService<DbInitializer>().Initialize().Wait();
            base.OnStartup(e);
            await host.StartAsync();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            var host = Host;
            base.OnExit(e);
            await host.StopAsync();
        }
    }
}
