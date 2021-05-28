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
        DbSet<Course> Course { get; set; }
        DbSet<Standard> Standard { get; set; }
        DbSet<Student> Student { get; set; }
        DbSet<StudentAddress> StudentAddress { get; set; }
        DbSet<StudentCourse> StudentCourse { get; set; }
        DbSet<Teacher> Teacher { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            Builder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VervolgToLinq;Trusted_Connection=True;");
        }
    }
}
