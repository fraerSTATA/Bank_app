using Bank_app.DAL.Entityes;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.Services
{
    public class MakingCredit
    {      
        private readonly IRepository<CreditRequest> _credit;
        public MakingCredit(IRepository<CreditRequest> credit)
        {
           _credit = credit;
        }

        public void MakeCredit(CreditRequest request)
        {
            if (request != null)
                _credit.Add(request);
        }
    }
}

