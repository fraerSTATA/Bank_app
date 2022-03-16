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
             .AddTransient<IRepository<CheckedCreditRequest>, CheckedCreditRequestRepository>()
             .AddTransient<IRepository<CreditRequest>, CreditRequestRepository>()
             .AddTransient<IRepository<CreditView>, CreditViewRepository>()
             .AddTransient<IRepository<CreditType>, DbRepository<CreditType>>()
             .AddTransient<IRepositoryUser<User>, DbRepositoryUser<User>>()
             .AddTransient<IRepositoryUser<Employee>, EmployeeRepository>()
            ;
    }
}
