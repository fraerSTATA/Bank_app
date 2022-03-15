using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes
{
    public class CheckedCreditRequest : Entity
    {

        public string status { get; set; } 
        public virtual Employee Employee{ get; set; }
        public virtual CreditRequest CreditRequest { get; set; }
    }
}
