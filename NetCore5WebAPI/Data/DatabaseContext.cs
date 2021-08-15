using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {}
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clinic>().HasData(
                new Clinic
                {
                    Id = 1,
                    Name = "Kan Dental Clinic",
                    EmailAddress = "kandental@gmail.com"

                },
                new Clinic
                {
                    Id = 2,
                    Name = "Tot Dental Clinic",
                    EmailAddress = "totdental@gmail.com"
                },
                new Clinic
                {
                    Id = 3,
                    Name = "3Times Dental Clinic",
                    EmailAddress = "3timesdental@gmail.com"
                }
            );

            builder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    LastName = "de los Reyes",
                    FirstName = "Lou II",
                    MiddleName = "Bohol",
                    Rating = 5.0,
                    ClinicId = 1
                },
                new Doctor
                {
                    Id = 2,
                    LastName = "Cruz",
                    FirstName = "Louie",
                    MiddleName = "Santos",
                    Rating = 4.3,
                    ClinicId = 3
                },
                new Doctor
                {
                    Id = 3,
                    LastName = "Perez",
                    FirstName = "Jackou",
                    MiddleName = "Lim",
                    Rating = 3.5,
                    ClinicId = 2
                }
            );
        }
    }
}
