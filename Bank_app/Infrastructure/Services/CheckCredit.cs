using Bank_app.DAL.Entityes;
using Bank_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.Services
{
    internal class CheckCredit
    {
        IRepository<CreditRequest> a;
        IRepository<CheckedCreditRequest> b;

        public CheckCredit(IRepository<CreditRequest> repository, IRepository<CheckedCreditRequest> beb)
        {
             a = repository;
             b = beb;
        }

        public void CheckCreditRequest(bool status,CreditRequest req,Employee e)
        {
            if (status)
            {
                b.Add(new CheckedCreditRequest { status = "принят", CreditRequest = req, Employee = e });
                req.status = "Одобрена";
                a.Update(req);
            }
            else
            {
                b.Add(new CheckedCreditRequest { status = "отклонен", CreditRequest = req, Employee = e });
                req.status = "Отклонена";
                a.Update(req);
            }
        }
    }
}
