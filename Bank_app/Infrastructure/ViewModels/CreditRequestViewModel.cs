using Bank_app.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public CreditRequestViewModel(CreditRequest creditRequesst)
        {
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
