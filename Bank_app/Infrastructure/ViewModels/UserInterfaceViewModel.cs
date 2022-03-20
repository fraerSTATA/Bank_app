using Bank_app.DAL.Entityes;
using Bank_app.DAL.Entityes.Base;
using Bank_app.Infrastructure.Commands;
using Bank_app.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class UserInterfaceViewModel : BaseViewModel
    {

        private User user;

        public User User { get => user; set => Set<User>(ref user, value); }

        /// <summary>
        /// Открытие окна регистрации
        /// </summary>
        private ICommand makeCredit;

        public ICommand MakeCredit => makeCredit ??= new LambdaCommand(OnMakeCreditCommandExecute, CanExecuteMakeCreditCommandExecute);

        private void OnMakeCreditCommandExecute(object p)
        {

            MakeCredit a = new();
            a.Show();
        }
        private bool CanExecuteMakeCreditCommandExecute(object p) => true;

        public UserInterfaceViewModel(AutorisationViewModel a)
        {
            user = (User)a.per;
        }

       
    }
}
