using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bank_app.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Bank_app.DAL.Entityes;

namespace Bank_app.Data
{
   
    class DbInitializer
    {
        private readonly Bank_appDB _db;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(Bank_appDB db, ILogger<DbInitializer> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task  Initialize()
        {
           /*var a = _db.Posts.Take<Post>(10).ToList();
           
            MessageBox.Show(a[0].descript);*/
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            if (await _db.Posts.AnyAsync()) return;
        }
    }
}
