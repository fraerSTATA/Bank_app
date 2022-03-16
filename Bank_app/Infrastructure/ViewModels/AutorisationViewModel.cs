using System.Net.Mime;
using System.Windows;
using System.Windows.Input;
using Bank_app.DAL.Entityes;
using Bank_app.Infrastructure.Commands;
using Bank_app.Interfaces;
using System.Linq;
using Bank_app.DAL.Context;

namespace Bank_app
{
    internal class AutorisationViewModel : BaseViewModel
    {
        private string? userLogin;
        private string? password;

        private string title = "Тут был Саня";
        private readonly IRepositoryUser<Employee> employers;

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
        #endregion
        public AutorisationViewModel(IRepositoryUser<Employee> users) 
        {
            // employers = employer;
            var emp = users.Items.Take(1).ToArray();
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanExecuteCloseApplicationCommandExecute);
        }
    }
}
