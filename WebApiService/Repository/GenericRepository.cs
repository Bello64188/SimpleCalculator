using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Data;
using WebApiService.IRepository;

namespace WebApiService.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        private readonly AppDbContext _cxt;
        private readonly DbSet<T> _db;

        public GenericRepository(AppDbContext context)
        {
            _cxt = context;
            _db = _cxt.Set<T>();
        }

        public IEnumerable<T> GetLogs()
        {
            return _db.ToList();
        }
    }

}
