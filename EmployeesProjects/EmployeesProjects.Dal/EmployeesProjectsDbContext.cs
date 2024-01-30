using EmployeesProjects.Dal.EntityTypeConfiguration;
using EmployeesProjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Dal
{
    public class EmployeesProjectsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.EnableSensitiveDataLogging(true);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LLGUTIH;Database=EmployeesProjectsDB;Uid=sa;Pwd=123");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //   modelBuilder.ApplyConfiguration(new EmployeeTypeConfiguration());
            modelBuilder.Entity<EmployeeProject>().Property(x => x.ID).UseIdentityColumn();
            modelBuilder.Entity<Employee>().Property(x => x.ID).UseIdentityColumn();
           modelBuilder.Entity<Project>().Property(x => x.ID).UseIdentityColumn();


            base.OnModelCreating(modelBuilder);
        }
    }
}
