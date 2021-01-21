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
            modelBuilder.Entity<BusinessUnitType>().HasData(
              new BusinessUnitType { Id = 1, Name = "Management" },
              new BusinessUnitType { Id = 2, Name = "RugbyTeam" }
             );

            modelBuilder.Entity<EmployeeType>().HasData(
              new EmployeeType { Id = 1, Name = "Management" },
              new EmployeeType { Id = 2, Name = "Admin" },
              new EmployeeType { Id = 3, Name = "Coach" },
              new EmployeeType { Id = 4, Name = "Physiotherapist" },
              new EmployeeType { Id = 5, Name = "Player" }
             );

            modelBuilder.Entity<BusinessUnitLocation>().HasData(
              new BusinessUnitLocation
                {
                    Id = 1,
                    Name = "Loftus Versfeld Stadium",
                    PhysicalLine1 = "416 Kirkness St",
                    PhysicalLine2 = "Arcadia",
                    PhysicalTown = "Pretoria",
                    PhysicalCode = "0007"
                },
              new BusinessUnitLocation
                {
                    Id = 2,
                    Name = "Ellis Park Stadium",
                    PhysicalLine1 = "S Park Ln",
                    PhysicalLine2 = "New Doornfontein",
                    PhysicalTown = "Johannesburg",
                    PhysicalCode = "2094"
                },
              new BusinessUnitLocation
                {
                    Id = 3,
                    Name = "Toyota Stadium",
                    PhysicalLine1 = "Willows",
                    PhysicalLine2 = "",
                    PhysicalTown = "Bloemfontein",
                    PhysicalCode = "9320"
                },
              new BusinessUnitLocation
                {
                    Id = 4,
                    Name = "Newlands Rugby Stadium",
                    PhysicalLine1 = "8 Boundary Rd",
                    PhysicalLine2 = "Newlands",
                    PhysicalTown = "Cape Town",
                    PhysicalCode = "7700"
                },
              new BusinessUnitLocation
                {
                    Id = 5,
                    Name = "Jonsson Kings Park",
                    PhysicalLine1 = "Jacko Jackson Dr",
                    PhysicalLine2 = "Stamford Hill",
                    PhysicalTown = "Durban",
                    PhysicalCode = "4025"
                }
            );

            modelBuilder.Entity<BusinessUnit>().HasData(
              new BusinessUnit
              {
                  Id = 1,
                  BusinessUnitTypeId = 1,
                  BusinessUnitLocationId = 1,
                  Name = "Blue Bulls"
              },
              new BusinessUnit
              {
                  Id = 2,
                  ParentBusinessUnitId = 1,
                  BusinessUnitTypeId = 2,
                  BusinessUnitLocationId = 1,
                  Name = "Super Rugby"
              },
              new BusinessUnit
              {
                  Id = 3,
                  ParentBusinessUnitId = 1,
                  BusinessUnitTypeId = 2,
                  BusinessUnitLocationId = 1,
                  Name = "Currie Cup"
              },
              new BusinessUnit
              {
                  Id = 4,
                  ParentBusinessUnitId = 1,
                  BusinessUnitTypeId = 2,
                  BusinessUnitLocationId = 1,
                  Name = "Under 21"
              },
              new BusinessUnit
              {
                  Id = 5,
                  ParentBusinessUnitId = 1,
                  BusinessUnitTypeId = 2,
                  BusinessUnitLocationId = 1,
                  Name = "Under 18"
              }
            );

            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 Id = 1,
                 Initials = "jw",
                 Firstnames = "Jake",
                 Surname = "White",
                 Email = "test@gmail.com",
                 CellNumber = "1234567890",
                 EmployeeTypeId = 3,
                 BusinessUnitId = 2,
             },
             new Employee
             {
                 Id = 2,
                 Initials = "hp",
                 Firstnames = "Handrè",
                 Surname = "Pollard",
                 Email = "test@gmail.com",
                 CellNumber = "1234567890",
                 EmployeeTypeId = 5,
                 BusinessUnitId = 2,
             },
             new Employee
             {
                 Id = 3,
                 Initials = "wg",
                 Firstnames = "Warrick",
                 Surname = "Gelant",
                 Email = "test@gmail.com",
                 CellNumber = "1234567890",
                 EmployeeTypeId = 5,
                 BusinessUnitId = 2,
             }
            );

            modelBuilder.Entity<PlayerData>().HasData(
             new PlayerData
             {
                 Id = 1,
                 EmployeeId = 2,
                 Weight = 96,
                 Height = 1.88,
                 Age = 26
             },
             new PlayerData
             {
                 Id = 2,
                 EmployeeId = 3,
                 Weight = 85,
                 Height = 1.78,
                 Age = 25
             }
            );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
