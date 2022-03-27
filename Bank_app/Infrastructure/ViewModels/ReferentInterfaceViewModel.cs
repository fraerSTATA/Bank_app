using Bank_app.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_app.Infrastructure.Commands;
using Bank_app.Interfaces;
using Bank_app.DAL.Context;
using Bank_app.Infrastructure.Services;
using Bank_app.Windows;
using Bank_app.DAL.Entityes.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class ReferentInterfaceViewModel : BaseViewModel
    {
        #region Свойства
        private Employee employee;
        private string title;
      

        public Employee Employee { get { return employee; } set { Set(ref employee, value); } }
        public string Title { get => title; set => Set(ref title,value); }

        #endregion

        #region Команды
        /// <summary>
        /// Открытие окна просмотра пользовательских заявок
        /// </summary>
        private ICommand checkRequests;

        public ICommand CheckRequests => checkRequests ??= new LambdaCommand(OnCheckRequestsCommandExecute, CanExecuteCheckRequestsCommandExecute);

        private void OnCheckRequestsCommandExecute(object p)
        {

           UserCreditRequest a = new();
            a.Show();
        }
        private bool CanExecuteCheckRequestsCommandExecute(object p) => true;
        #endregion

        public ReferentInterfaceViewModel(AutorisationViewModel a,IRepository<CreditRequest> rep)
        {
            Employee =  (Employee)a.per ?? throw new ArgumentNullException();

            Title = "Здравсвтуйте, " + employee.name;
        }
    }
}
