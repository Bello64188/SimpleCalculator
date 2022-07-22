using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Model
{
    public class Log
    {
        public Log()
        {
            Date = DateTime.Now;
        }
        public int Id { get; set; }
        public string Logs { get; set; }

        public DateTime Date { get; set; }

    }
}
