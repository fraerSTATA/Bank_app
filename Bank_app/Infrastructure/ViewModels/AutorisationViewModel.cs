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
using Bank_app.DAL.Entityes.Base;
using Xunit;

namespace Bank_app
{
    public class AutorisationViewModel : BaseViewModel
    {
        private string? userLogin;
        private string? password;
        
        private string title = "Bruiser Bank";

        private readonly IRepositoryUser<Employee> users;
        private readonly Autorisated autorisated;
       

        #region Свойства
        public Person per;
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
        /// <summary>
        /// Открытие окна регистрации
        /// </summary>
        private ICommand openReigstryCommand;

        public ICommand OpenReigstryCommand => openReigstryCommand ??= new LambdaCommand(OnOpenReigstryCommandExecute, CanExecuteOpenReigstryCommandExecute);

        private void OnOpenReigstryCommandExecute(object p)
        {
          
            Registry a = new();              
            a.Show();
        }

        private bool CanExecuteOpenReigstryCommandExecute(object p) => true;

        /// <summary>
        /// Закрытие главного окна
        /// </summary>
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanExecuteCloseApplicationCommandExecute(object p) => true;


        /// <summary>
        /// Авторизация
        /// </summary>
        private ICommand loginCommand;

        public ICommand LoginCommand => loginCommand ??= new LambdaCommand(OnLoginCommandExecute, CanExecuteLoginCommandExecute);

        private void OnLoginCommandExecute(object p)
        {
            var emp = autorisated.Autorise(userLogin, password);
            if (emp.Value != null)
            {
                per = emp.Value;
                if (emp.Key == "сотрудник")
                {
                    ReferentInterface b = new ReferentInterface();
                    b.Show();
                    foreach (Window item in Application.Current.Windows)
                    {
                        if (item.DataContext == this) item.Close();
                    }
                }
                if (emp.Key == "пользователь")
                {
                    UserInterface a = new UserInterface();
                    a.Show();
                    foreach (Window item in Application.Current.Windows)
                    {
                        if (item.DataContext == this) item.Close();
                    }
                }
            }             
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private bool CanExecuteLoginCommandExecute(object p){
         
                return true;
 
            }

        #endregion
        public AutorisationViewModel(Autorisated autorisated) 
        {                                
            this.autorisated = autorisated;

          
    
           

        }
    }
}
