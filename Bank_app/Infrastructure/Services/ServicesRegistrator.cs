using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Bank_app.Data;
using Bank_app.Infrastructure.Services;

namespace Bank_app.Infrastructure.Services
{
    public static class ServicesRegistator
    {

        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<DbInitializer>()
            .AddTransient<Autorisated>()
            .AddTransient<Registrated>()
            .AddTransient<MakingCredit>()
        ;
    }
}
