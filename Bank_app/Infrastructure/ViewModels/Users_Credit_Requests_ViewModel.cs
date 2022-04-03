using Bank_app.DAL.Entityes;
using Bank_app.Infrastructure.Commands;
using Bank_app.Infrastructure.Services;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class Users_Credit_Requests_ViewModel : BaseViewModel
    {
        #region Свойства
        private int index;
        private readonly Employee _employee;
        private IRepository<CreditRequest> creditRequestsRepository;
        private readonly CheckCredit check;
        private ObservableCollection<CreditRequestViewModel> credits = new ObservableCollection<CreditRequestViewModel>();
       
        public int Index { get => index; set => Set(ref index, value); }
        public ObservableCollection<CreditRequestViewModel> Credits { get => credits; set => Set(ref credits, value); }
        #endregion

       
        internal void UpdateCreditViews()
        {
            foreach (var view in creditRequestsRepository.Items.Where(item => item.status == "рассмотрение"))
            {
               
                Bank_app.Windows.DataTemplates.UserRequestView creditView = new Bank_app.Windows.DataTemplates.UserRequestView();
                CreditRequestViewModel model = new CreditRequestViewModel(view,_employee,check,credits,index);
                creditView.DataContext = model;
                credits.Add(model);
            }          
        }

        public Users_Credit_Requests_ViewModel(IRepository<CreditRequest> rep,ReferentInterfaceViewModel a, CheckCredit check)
        {
            _employee = a.Employee;
            creditRequestsRepository = rep;
            this.check = check;
           
            UpdateCreditViews();
        }
    }
}
