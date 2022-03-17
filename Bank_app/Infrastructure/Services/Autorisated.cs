using Bank_app.DAL.Entityes;
using Bank_app.DAL.Entityes.Base;
using Bank_app.Infrastructure.Services.Interface;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.Services
{
    public class Autorisated : IAutorisated
    {
        private readonly IRepositoryUser<User> users;
        private readonly IRepositoryUser<Employee> employers;

        public Person? person { get; private set; }
        public Autorisated(IRepositoryUser<User> users, IRepositoryUser<Employee> employers)
        {
            this.users = users;
            this.employers = employers;
        }

        public KeyValuePair<string,Person?> Autorise(string login,string password)
        {
            string role = "";
            person = users.Items.FirstOrDefault(u => u.id == login && u.password == password);
            if (person == null)
            {
                person = employers.Items.FirstOrDefault(u => u.id == login && u.password == password);
                role = "сотрудник";
                if (person == null)
                {
                    role = "ошибка";
                }
            }
            else
            {
                role = "пользователь";
            }

            return new KeyValuePair<string, Person?>(role,person);
        }
    }
}
