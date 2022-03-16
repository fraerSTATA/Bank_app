using Bank_app.DAL.Entityes;
using Bank_app.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL
{
  public static class RepositoryRegistator
    {

        public static IServiceCollection AddRepositoriesInDB(this IServiceCollection services) => services
            .AddTransient<IRepository<Post>,DbRepository<Post>>()
             .AddTransient<IRepository<CheckedCreditRequest>, DbRepository<CheckedCreditRequest>>()
             .AddTransient<IRepository<CreditRequest>, DbRepository<CreditRequest>>()
             .AddTransient<IRepository<CreditView>, DbRepository<CreditView>>()
             .AddTransient<IRepository<CreditType>, DbRepository<CreditType>>()
            .AddTransient<IRepositoryUser<User>, DbRepositoryUser<User>>()
             .AddTransient<IRepositoryUser<Employee>, DbRepositoryUser<Employee>>()
            ;
    }
}
