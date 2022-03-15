using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes
{
   public class CreditRequest : Entity
    {

        public virtual User User { get; set; }  
        public virtual CreditView CreditView { get; set; }
        public int salary   { get; set; }
        public int workbook { get; set; }
        public int credit_sum { get; set; }
        public string status { get; set; }
            
        public virtual ICollection<CheckedCreditRequest> CreditRequests { get; set; }
    }
}
