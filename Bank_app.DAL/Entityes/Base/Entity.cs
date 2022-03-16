using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_app.Interfaces;

namespace Bank_app.DAL.Entityes.Base
{
    public abstract class Entity : IEntity
    {
        public int id { get; set; }
    }

   
}
