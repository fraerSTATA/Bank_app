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
        public DbSet<CheckedCreditRequest> CheckedCreditRequests { get; set; }
        public DbSet<CreditType> CreditTypes { get; set; }
        public DbSet<CreditView> CreditViews { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public Bank_appDB(DbContextOptions<Bank_appDB> options) : base(options)
        {
                
        }
    }
}
