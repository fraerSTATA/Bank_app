using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes.Base
{
    public abstract class UserEntity
    {
        public string id { get; set; }
        public string password { get; set; }

    }
}
