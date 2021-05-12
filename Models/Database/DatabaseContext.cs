using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace solutionthree.Models.Database
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base (options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Person>()
                .HasData(
                    new Person
                    {
                        id = 1,
                        firstName = "Joe",
                        lastName = "Soap",
                        age = 27
                    },
                    new Person
                    {
                        id = 2,
                        firstName = "Daniel",
                        lastName = "Moshe",
                        age = 35
                    },
                    new Person
                    {
                        id = 3,
                        firstName = "Seth",
                        lastName = "Smith",
                        age = 29
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> person { get; set; }


        

    }
}
