using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.DAL.Entityes.Base
{
    public class Person : UserEntity
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int passport { get; set; }
    }
}
