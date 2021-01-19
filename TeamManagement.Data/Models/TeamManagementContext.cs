using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TeamManagement.Data.Models
{
    public partial class TeamManagementContext : DbContext
    {
        public TeamManagementContext()
        {
        }

        public TeamManagementContext(DbContextOptions<TeamManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusinessUnit> BusinessUnit { get; set; }
        public virtual DbSet<BusinessUnitLocation> BusinessUnitLocation { get; set; }
        public virtual DbSet<BusinessUnitType> BusinessUnitType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<PlayerData> PlayerData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
