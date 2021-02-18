using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Samarghitean_Ciprian_Lab8.Models;

namespace Samarghitean_Ciprian_Lab8.Data
{
    public class Samarghitean_Ciprian_Lab8Context : DbContext
    {
        public Samarghitean_Ciprian_Lab8Context(DbContextOptions<Samarghitean_Ciprian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Samarghitean_Ciprian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Samarghitean_Ciprian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Samarghitean_Ciprian_Lab8.Models.Category> Category { get; set; }
    }
}
