using Bank_app.DAL.Entityes;
using Bank_app.Infrastructure.Commands;
using Bank_app.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class CreditRequestViewModel : BaseViewModel
    {
        private CreditRequest creditRequest;
        private string title;
        private string name;
        private string surname;
       
        private int time;
        private int percent;
        private string descript;

        private int workBook;
        private int salary;
        private int credit_Sum;

        public string Title { get => title; set => Set(ref title,value); }
        public string Name { get => name; set => Set(ref name, value); }
        public string Surname { get => surname; set => Set(ref surname, value); }
        public int Time { get => time; set => Set(ref time, value); }
        public int Percent { get => percent; set => Set(ref percent, value); }
        public string Descript { get => descript; set => Set(ref descript, value); }
        public int WorkBook { get => workBook; set => Set(ref workBook, value); }
        public int Salary { get => salary; set => Set(ref salary, value); }
        public int Credit_Sum { get => credit_Sum; set=> Set(ref credit_Sum, value); }
        private bool status;
        private readonly CheckCredit check;
        private readonly int index;
        private readonly Employee employee;



        #region Команды
        /// <summary>
        /// Принять пользовательскую заявку
        /// </summary>
        private ICommand acceptRequests;

        public ICommand AcceptRequests => acceptRequests ??= new LambdaCommand(OnAcceptRequestsCommandExecute, CanExecuteAcceptRequestsCommandExecute);

        private void OnAcceptRequestsCommandExecute(object p)
        {
            status = true;
            check.CheckCreditRequest(status, creditRequest, employee);
            Credits.RemoveAt(index);

        }
        private bool CanExecuteAcceptRequestsCommandExecute(object p) => true;


        /// <summary>
        /// Отклонить пользовательскую заявку
        /// </summary>
        private ICommand declineRequests;

        public ICommand DeclineRequests => declineRequests ??= new LambdaCommand(OnDeclineRequestsCommandExecute, CanExecuteDeclineRequestsCommandExecute);

        public Users_Credit_Requests_ViewModel Cr { get; }
        public ObservableCollection<CreditRequestViewModel> Credits { get; }

        private void OnDeclineRequestsCommandExecute(object p)
        {
            status = false;
            check.CheckCreditRequest(status, creditRequest, employee);
            Credits.RemoveAt(index);
        }
        private bool CanExecuteDeclineRequestsCommandExecute(object p) => true;
        #endregion


        public CreditRequestViewModel(CreditRequest creditRequesst,Employee ex,CheckCredit credit, ObservableCollection<CreditRequestViewModel> credits,int index)
        {
            employee = ex;
            check = credit;
            Credits = credits;
            this.index = index;
            creditRequest = creditRequesst;
            title = "Заявка №" + creditRequesst.id;

            name = creditRequesst.User.name;
            surname = creditRequesst.User.surname;

            time = creditRequesst.CreditView.credit_time;
            percent = creditRequesst.CreditView.percent_credit;
            descript = creditRequesst.CreditView.descript;

            workBook = creditRequesst.workbook;
            salary = creditRequesst.salary;
            credit_Sum = creditRequesst.credit_sum;
            
        }

       
    }
}
