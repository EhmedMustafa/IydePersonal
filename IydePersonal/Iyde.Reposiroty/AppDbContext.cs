using Iyde.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyde.Reposiroty
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions options) : base(options)
        //{

        //}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-J6V60I6\\SQLEXPRESS;Initial catalog=Iyde;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Employees> employees { get; set; }
    }
}
