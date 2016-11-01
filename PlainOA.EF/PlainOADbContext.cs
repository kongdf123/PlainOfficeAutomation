using PlainOA.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainOA.EF
{
    public class PlainOADbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<TeamGroup> TeamGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            modelBuilder.Entity<EmployeeAccount>()
                        .HasKey(t => t.EmployeeId);
            // Map one-to-zero or one relationship 
            modelBuilder.Entity<EmployeeAccount>()
                .HasRequired(t => t.Employee)
                .WithOptional(t => t.EmployeeAccount);

            modelBuilder.Entity<TeamGroup>()
                .HasMany(t => t.Employees)
                .WithMany(t => t.TeamGroups);


            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
