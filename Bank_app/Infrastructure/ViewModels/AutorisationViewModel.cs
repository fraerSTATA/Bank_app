using System.Net.Mime;
using System.Windows;
using System.Windows.Input;
using Bank_app.DAL.Entityes;
using Bank_app.Infrastructure.Commands;
using Bank_app.Interfaces;
using System.Linq;
using Bank_app.DAL.Context;
using Bank_app.Infrastructure.Services;
using Bank_app.Windows;

namespace Bank_app
{
    internal class AutorisationViewModel : BaseViewModel
    {
        private string? userLogin;
        private string? password;

        private string title = "Bruiser Bank";

        private readonly IRepositoryUser<Employee> users;
        private readonly Autorisated autorisated;

        #region Свойства

        public string Title
        {
            get => this.title;
            set => Set(ref title, value);
        }
        public string UserLogin
        {
            get => this.userLogin;
            set => Set(ref userLogin, value);
        }
        public string Password
        {
            get => this.password;
            set => Set(ref password, value);
        }


        #endregion

        #region Команды
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanExecuteCloseApplicationCommandExecute(object p) => true;

        public ICommand LoginCommand { get; }

        private void OnLoginCommandExecute(object p)
        {
            var emp = autorisated.Autorise(userLogin, password);
            if (emp.Value != null)
            {
               if(emp.Key == "сотрудник")
                {
                   Registry a = new Registry();
                    a.Show();
                }
                if (emp.Key == "пользователь")
                {
                    MessageBox.Show("Синякуем");
                }
            }             
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private bool CanExecuteLoginCommandExecute(object p){
          //  if (userLogin != null && password != null && autorisated != null)
                return true;
         //   MessageBox.Show("Заполните все поля!");
        //    return false;
            }

        #endregion
        public AutorisationViewModel(Autorisated autorisated) 
        {
            // employers = employer;         
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanExecuteCloseApplicationCommandExecute);
            LoginCommand = new LambdaCommand(OnLoginCommandExecute, CanExecuteLoginCommandExecute);           
            this.autorisated = autorisated;         
            Password = "sadasdas";

        }
    }
}
