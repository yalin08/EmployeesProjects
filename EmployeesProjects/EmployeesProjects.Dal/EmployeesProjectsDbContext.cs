﻿using EmployeesProjects.Dal.EntityTypeConfiguration;
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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LLGUTIH;Database=EmployeesProjectsDB;Uid=sa;Pwd=123");
            // optionsBuilder.UseSqlServer(@"DESKTOP-VU62QDF\SQLSERVERMS;Database=EmployeesProjectsDB;Uid=sa;Pwd=123");
            //  optionsBuilder.UseSqlServer(@"Server=DESKTOP-G2S16HQ;Database=EmployeesProjectsDB;Uid=sa;Pwd=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
