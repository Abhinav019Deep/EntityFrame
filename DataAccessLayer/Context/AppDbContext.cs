using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
  
public class AppDbContext : DbContext

    {

        //public AppDbContext()

        //{

        //}

        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\AbhinavDeep\\Documents\\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");

        }

        public DbSet<Course> Courses { get; set; }

    }
}
