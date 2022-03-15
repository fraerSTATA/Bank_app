using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_app.DAL.Entityes;

namespace Bank_app.DAL.Context
{
  public class Bank_appDB : DbContext
    {
        DbSet<CheckedCreditRequest> CheckedCreditRequests { get; set; }
        DbSet<CreditType> CreditTypes { get; set; }
        DbSet<CreditView> CreditViews { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<User> Users { get; set; }

        public Bank_appDB(DbContextOptions<Bank_appDB> options) : base(options)
        {
                
        }
    }
}
