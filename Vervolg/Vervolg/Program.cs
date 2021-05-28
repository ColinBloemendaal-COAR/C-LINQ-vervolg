using System;
using System.Linq;

namespace Vervolg
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolDBEntities()) 
            { 
                var students = ctx.Students.GroupBy(s => s.StandardId); 
                foreach (var groupItem in students) 
                { 
                    Console.WriteLine(groupItem.Key); 
                    foreach (var stud in groupItem) 
                    { Console.WriteLine(stud.StudentId); 
                    } 
                }
            }

            Console.ReadLine();
        }
    }
}
