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
        private int percent;
        private int time;
        private string name;

        public CreditViewViewModel(CreditView a)
        {
            percent = a.percent_credit;
            time = a.credit_time;
            name = a.CreditType.type_name;
        }

        public int Percent { get => percent; set => Set(ref percent, value); }
        public int Time { get => time; set => Set(ref time, value); }
        public string Name { get => name; set => Set(ref name, value); }
    }
}
