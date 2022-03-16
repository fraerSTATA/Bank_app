using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Bank_app
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(App.ConfigureServices);
    }
}
