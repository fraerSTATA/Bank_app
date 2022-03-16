using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_app.Interfaces;
using Bank_app.DAL.Entityes.Base;
using Bank_app.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Bank_app.DAL
{
    class DbRepository<T> : IRepository<T> where T :class, IEntity , new()
    {

        private readonly Bank_appDB db;
        private readonly DbSet<T> Set;

        public bool AutoSaveChanges { get; set; } = true;
        public DbRepository(Bank_appDB _db)
        {
            db = _db;
            Set = db.Set<T>();
        }
        public virtual IQueryable<T> Items => Set;

        public  T Add(T item)
        {
            if(item is null) throw new ArgumentNullException(nameof(item));
            db.Entry(item).State = EntityState.Added;
            if(AutoSaveChanges)
                 db.SaveChanges();
            return item;
        }

        public async Task<T> AddAsync(T item, CancellationToken Cancel = default)
        {

            if (item is null) throw new ArgumentNullException(nameof(item));
            db.Entry(item).State = EntityState.Added;
            if (AutoSaveChanges)
               await db.SaveChangesAsync().ConfigureAwait(false);
            return item;
        }

        public T GetById(int id)
        {
            return Items.SingleOrDefault(item => item.id == id);
        }

        public async Task<T> GetByIdAsync(int id, CancellationToken Cancel = default) => await Items
           .SingleOrDefaultAsync(item => item.id == id, Cancel)
           .ConfigureAwait(false);

        public void Remove(int id)
        {
           db.Remove(new T { id = id});
            if (AutoSaveChanges)
                db.SaveChanges();
        }

        public async Task RemoveAsync(int id, CancellationToken Cancel = default)
        {
            db.Remove(new T { id = id });
            if (AutoSaveChanges)
                await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public void Update(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            db.Entry(item).State = EntityState.Modified;
            if (AutoSaveChanges)
                db.SaveChanges();
        }

        public async Task UpdateAsync(T item, CancellationToken Cancel = default)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            db.Entry(item).State = EntityState.Modified;
            if (AutoSaveChanges)
                await db.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
    