using Bank_app.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.ViewModels
{
    internal class CreditViewViewModel : BaseViewModel
    {
        private int brush = 3;
        private int percent;
        private int time;
        private string name;
        private CreditView creditView;
        public CreditViewViewModel(CreditView a)
        {
            creditView = a;
            percent = a.percent_credit;
            time = a.credit_time;
            name = a.descript;
        }

        public int Percent { get => percent; set => Set(ref percent, value); }
        public int Time { get => time; set => Set(ref time, value); }
        public int Brush { get => brush; set => Set(ref brush, value); }
        public string Name { get => name; set => Set(ref name, value); }
        public CreditView CreditView { get => creditView; set => creditView = value; }
    }
}
