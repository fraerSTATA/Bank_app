using Bank_app.DAL.Entityes;
using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class UserInterfaceViewModel : BaseViewModel
    {

        private User user;

        

        public UserInterfaceViewModel(AutorisationViewModel a)
        {
            user = (User)a.per;
        }

        public User User { get => user; set => Set<User>(ref user, value); }
    }
}
