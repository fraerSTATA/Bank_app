using Bank_app.DAL.Entityes;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class Users_Credit_Requests_ViewModel : BaseViewModel
    {
        private readonly Employee _employee;
        private IRepository<CreditRequest> creditRequestsRepository;
        private ObservableCollection<CreditRequestViewModel> credits = new ObservableCollection<CreditRequestViewModel>();

        public ObservableCollection<CreditRequestViewModel> Credits { get => credits; set => Set(ref credits, value); }

        private void UpdateCreditViews()
        {
            foreach (var view in creditRequestsRepository.Items)
            {
                Bank_app.Windows.DataTemplates.UserRequestView creditView = new Bank_app.Windows.DataTemplates.UserRequestView();
                CreditRequestViewModel model = new CreditRequestViewModel(view);
                creditView.DataContext = model;
                credits.Add(model);
            }
            int h = 0;
        }

        public Users_Credit_Requests_ViewModel(IRepository<CreditRequest> rep,ReferentInterfaceViewModel a)
        {
            _employee = a.Employee;
            creditRequestsRepository = rep;
            UpdateCreditViews();
        }
    }
}
