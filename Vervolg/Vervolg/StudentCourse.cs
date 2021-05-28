using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vervolg
{
    [Keyless]
    class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
