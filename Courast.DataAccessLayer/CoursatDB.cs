using Coursat.tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Coursat.DataAccessLayer
{
   public class CoursatDB: IdentityDbContext
    {

        public CoursatDB(DbContextOptions<CoursatDB> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

       public DbSet<Student> students { get; set; }
       public DbSet<Teacher> teachers { get; set; }
       public DbSet<ClassRoom> classRooms { get; set; }
       public DbSet<EducationalLevel> educationalLevels { get; set; }



    }
}
