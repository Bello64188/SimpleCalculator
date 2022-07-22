using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.IRepository
{
     public interface IGenericRepository <T> where T : class
    {
        IEnumerable<T> GetLogs();
    }
}
