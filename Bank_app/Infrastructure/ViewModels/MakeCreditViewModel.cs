using Bank_app.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class MakeCreditViewModel : BaseViewModel
    {

        private User user;

        private int workBook;
        private int salary;
        private int credit_sum;
        private CreditView creditView;

        public User User { get { return user; } set => Set(ref user, value); }

        
        public int WorkBook { get => workBook; set => Set(ref workBook, value); }
        public int Salary { get => salary; set => Set(ref salary, value); }
        public int Credit_sum { get => credit_sum; set => Set(ref credit_sum, value); }

        public MakeCreditViewModel(UserInterfaceViewModel a)
        {
            user = a.User;
        }
    }
}
