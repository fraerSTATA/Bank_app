using Bank_app.DAL.Entityes;
using Bank_app.Infrastructure.Services;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_app.Infrastructure.ViewModels
{
    internal class MakeCreditViewModel : BaseViewModel
    {

        private User user;

        private int workBook;
        private int salary;
        private int credit_sum;
        private CreditView creditView;     
        private readonly MakingCredit b;
        private readonly IRepository<CreditView> views;
        private ObservableCollection<Bank_app.Windows.DataTemplates.CreditView> credits =new ObservableCollection<Windows.DataTemplates.CreditView>();

        public User User { get { return user; } set => Set(ref user, value); }

        private void UpdateCreditViews()
        {
            foreach (var view in views.Items)
            {
                Bank_app.Windows.DataTemplates.CreditView creditView = new Bank_app.Windows.DataTemplates.CreditView();
                CreditViewViewModel model = new CreditViewViewModel(view);
                creditView.DataContext = model;
                credits.Add(creditView);               
            }
            int h = 0;
        }
        public int WorkBook { get => workBook; set => Set(ref workBook, value); }
        public int Salary { get => salary; set => Set(ref salary, value); }
        public int Credit_sum { get => credit_sum; set => Set(ref credit_sum, value); }
        public ObservableCollection<Windows.DataTemplates.CreditView> Credits { get => credits; set => Set(ref credits, value); }

        public MakeCreditViewModel(UserInterfaceViewModel a, MakingCredit b, IRepository<CreditView> views)
        {
            user = a.User;
            this.b = b;
            this.views = views;
            UpdateCreditViews();
        }
    }
}
