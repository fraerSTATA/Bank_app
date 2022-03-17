using Bank_app.DAL.Entityes;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.Services
{
    public class Registrated
   
    {
        private readonly IRepositoryUser<User> users;
       

      
        public Registrated(IRepositoryUser<User> users)
        {
            this.users = users;        
        }

        public void Registr(User? user)
        {
            if (user != null)
                users.Add(user);
               }
        }
    }
}

