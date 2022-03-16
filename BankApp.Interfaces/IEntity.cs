using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Interfaces
{
    public interface IEntity
    {
        int id { get; set; }
    }

    public interface IUserEntity
    {
        string id { get; set; }
    }

    public interface IRepository<T> where T :class, IEntity, new()
    {
        IQueryable<T> Items { get; }

        T GetById(int id);
        Task<T>  GetByIdAsync(int id,CancellationToken Cancel = default);
        T Add (T item);
        Task<T> AddAsync(T item, CancellationToken Cancel = default);
      
        void Update (T item);
        Task UpdateAsync(T item, CancellationToken Cancel = default);
        void Remove(int id);
        Task RemoveAsync(int id,CancellationToken Cancel = default);
    }

    public interface IRepositoryUser<T> where T : class,IUserEntity, new()
    {
        IQueryable<T> Items { get; }

        T GetById(string id);
        Task<T> GetByIdAsync(string id, CancellationToken Cancel = default);
        T Add(T item);
        Task<T> AddAsync(T item, CancellationToken Cancel = default);

        void Update(T item);
        Task UpdateAsync(T item, CancellationToken Cancel = default);
        void Remove(string id);
        Task RemoveAsync(string id, CancellationToken Cancel = default);
    }
}
