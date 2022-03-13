﻿

using System.Net.Mime;
using System.Windows;
using System.Windows.Input;
using Bank_app.Infrastructure.Commands;

namespace Bank_app
{
    internal class AutorisationViewModel : BaseViewModel
    {
        private string? userLogin;
        private string? password;

        #region Свойства
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
        public AutorisationViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanExecuteCloseApplicationCommandExecute);
        }
    }
}
