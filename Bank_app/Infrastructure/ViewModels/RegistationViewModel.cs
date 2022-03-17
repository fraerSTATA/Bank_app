using Bank_app.DAL.Context;
using Bank_app.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class RegistationViewModel : BaseViewModel
    {
        private readonly Bank_appDB autorisated;

        public RegistationViewModel(Bank_appDB db)
        {
            this.autorisated = autorisated;
            // employers = employer;         
            // CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanExecuteCloseApplicationCommandExecute);
            //    LoginCommand = new LambdaCommand(OnLoginCommandExecute, CanExecuteLoginCommandExecute);
            //     this.autorisated = autorisated;
            //    Password = "sadasdas";

        }
    }
}
