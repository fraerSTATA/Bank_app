using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes
{
    public class Employee : Person 
    {
        public virtual Post Post { get; set; }
        public virtual ICollection<CheckedCreditRequest> CheckedCreditRequests { get; set; }
    }
}
