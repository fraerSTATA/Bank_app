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
using System.Windows;
using System.Windows.Input;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class MakeCreditViewModel : BaseViewModel
    {

        private User user;

        private int workBook;
        private int salary;
        private int credit_sum;   
        private readonly MakingCredit makingCredit;
        private readonly IRepository<CreditView> views;


        private ObservableCollection<CreditViewViewModel> credits =new ObservableCollection<CreditViewViewModel>();
        private CreditViewViewModel currentCreditView;
        public User User { get { return user; } set => Set(ref user, value); }

        private void UpdateCreditViews()
        {
            foreach (var view in views.Items)
            {
                Bank_app.Windows.DataTemplates.CreditView creditView = new Bank_app.Windows.DataTemplates.CreditView();
                CreditViewViewModel model = new CreditViewViewModel(view);
                creditView.DataContext = model;
                credits.Add(model);               
            }
            int h = 0;
        }
        public int WorkBook { get => workBook; set => Set(ref workBook, value); }
        public int Salary { get => salary; set => Set(ref salary, value); }
        public int Credit_sum { get => credit_sum; set => Set(ref credit_sum, value); }
        public ObservableCollection<CreditViewViewModel> Credits { get => credits; set => Set(ref credits, value); }
        public CreditViewViewModel CurrentCreditView { 
            get => currentCreditView; 
            set => Set(ref currentCreditView, value); }


        #region Команды
        /// <summary>
        /// Отправка кредитной заявки
        /// </summary>
        private ICommand creditRequestCommand;

        public ICommand CreditRequestCommand => creditRequestCommand ??= new LambdaCommand(OnCreditRequestCommandExecute, CanExecuteCreditRequestCommandCommandExecute);

        private void OnCreditRequestCommandExecute(object p)
        {
            makingCredit.MakeCredit(new CreditRequest { CreditView = currentCreditView.CreditView, User = user, salary = Salary, status = "рассмотрение", credit_sum = Credit_sum, workbook = WorkBook });
            MessageBox.Show("Заявка успешно сформирована");
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }
        }

        private bool CanExecuteCreditRequestCommandCommandExecute(object p) => true;
        #endregion
        public MakeCreditViewModel(UserInterfaceViewModel a, MakingCredit b, IRepository<CreditView> views)
        {
            user = a.User;
            this.makingCredit = b;
            this.views = views;
            UpdateCreditViews();
        }
    }
}
