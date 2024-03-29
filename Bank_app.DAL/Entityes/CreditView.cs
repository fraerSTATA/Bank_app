﻿using Bank_app.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes
{
   public  class CreditView : Entity
    {
        public string descript { get; set; }
        public int percent_credit { get; set; }
        public int credit_time { get; set; }
        public virtual CreditType CreditType { get; set; }
        public virtual ICollection<CreditRequest> CreditRequests { get; set; } 
    }
}
