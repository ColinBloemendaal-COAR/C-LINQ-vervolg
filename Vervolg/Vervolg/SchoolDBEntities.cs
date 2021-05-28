using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vervolg
{
    class SchoolDBEntities : DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            Builder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VervolgToLinq;Trusted_Connection=True;");
        }
    }
}
