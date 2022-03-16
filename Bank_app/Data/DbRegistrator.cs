using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_app.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Bank_app.DAL;

namespace Bank_app.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services,IConfiguration Configuration) => services
        .AddDbContext<Bank_appDB>(opt =>
        {
            var type = Configuration["Type"];
            opt.UseSqlServer(Configuration.GetConnectionString(type));
        })
           .AddTransient<DbInitializer>()
           .AddRepositoriesInDB()
            ;
    }
}
