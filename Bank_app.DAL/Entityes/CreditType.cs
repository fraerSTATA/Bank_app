using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes
{
    public class CreditType : Entity
    {
        public string type_name { get; set; }
        public virtual ICollection<CreditView> Credit_views { get; set; }
    }
}
