using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Model;

namespace WebApiService.Data
{
    public class AppDbContext : DbContext
    {
        
        public DbSet<Log> CalculatorsLogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("FileName=CalculatorLogs.sqlite;");
        }
    
    }
}
