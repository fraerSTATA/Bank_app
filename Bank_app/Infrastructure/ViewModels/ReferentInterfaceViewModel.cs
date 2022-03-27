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
        public ReferentInterfaceViewModel(AutorisationViewModel a)
        {
            Employee =  (Employee)a.per ?? throw new ArgumentNullException();

            Title = "Здравсвтуйте, " + employee.name;
        }
    }
}
