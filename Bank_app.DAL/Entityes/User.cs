using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes
{
    public class User : Person
    {
        public int INN { get; set; }
        public virtual ICollection<CreditRequest> CreditRequests { get; set; }
    }
}
