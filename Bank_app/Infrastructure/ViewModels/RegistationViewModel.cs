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

namespace Bank_app.Infrastructure.ViewModels
{
    internal class RegistationViewModel : BaseViewModel
    {
       
        Person per = new Person();
        private readonly Registrated registrated;
        private string id;
        private string name;
        private string surname;
        private string password;
        private int inn;
        private int passport;
        public string Id { get => id; set => Set(ref id, value); }
        public string Name { get => name; set => Set(ref name, value); }
        public string Surname { get => surname; set => Set(ref surname, value); }
        public string Password { get => password; set => Set(ref password, value); }
        public int Inn { get => inn; set => Set(ref inn, value); }
        public int Passport { get => passport; set => Set(ref passport, value); }

      

        private void OnRegCommandExecute(object p)
        {          
            registrated.Registr(new User { id = Id, INN = inn, name = name, passport = passport, surname = surname, password = password });
            
        }

        private bool CanExecuteRegCommandExecute(object p) => true;

        public ICommand RegCommand { get; }

        public RegistationViewModel(Registrated db, AutorisationViewModel a)
        {
            per = a.per;
            this.registrated = db;
            RegCommand = new LambdaCommand(OnRegCommandExecute, CanExecuteRegCommandExecute);
        

        }

        
    }
}
