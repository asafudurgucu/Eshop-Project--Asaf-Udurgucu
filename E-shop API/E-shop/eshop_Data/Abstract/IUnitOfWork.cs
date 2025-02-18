using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Data.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class;
        Task<int> SaveAsync();
        public void Detach<TEntity>(TEntity entity) where TEntity : class;
    }
}
