using eshop_Data.Abstract;
using eshop_Data.Contcrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EshopDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(EshopDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<IGenericRepository<T>>();    
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Detach<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Detached;
        }

    }
}
